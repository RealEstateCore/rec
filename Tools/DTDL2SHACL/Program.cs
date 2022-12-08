using CommandLine;
using DotNetRdfExtensions.SHACL;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;
using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Shacl;
using VDS.RDF.Writing;
using DotNetRdfExtensions;

namespace DTDL2SHACL 
{
    internal class Program 
    {
        public class Options
        {
            [Option('i', "inputPath", Required = true, HelpText = "The path to the DTDL ontology root directory or file.")]
            public string InputPath { get; set; } = string.Empty;
            [Option('o', "outputPath", Required = true, HelpText = "The path to the output SHACL file.")]
            public string OutputPath { get; set; } = string.Empty;
            [Option('n', "namespaceMappingsPath", Required = true, HelpText = "Path to namespace mappings CSV file.")]
            public string NamespaceMappingsPath { get; set; } = string.Empty;
        }

        // Configuration fields
        private static string _inputPath = string.Empty;
        private static string _outputPath = string.Empty;
        private static string _namespaceMappingsPath = string.Empty;

        // Data fields
        private static IReadOnlyDictionary<Dtmi, DTEntityInfo>? _ontology;
        private static readonly OntologyGraph _ontologyGraph = new OntologyGraph();
        private static readonly ShapesGraph _shapesGraph = new(_ontologyGraph);

        // ID translation
        private static Dictionary<string,string> _dtmiBaseToUriBase = new();

        // DT schema translation
        private static Dictionary<Type,Uri> _dtdlSchemaToXsd = new() {
            {typeof(DTBooleanInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeBoolean)},
            {typeof(DTDateInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeDate)},
            {typeof(DTDateTimeInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeTime)},
            {typeof(DTDoubleInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeDouble)},
            {typeof(DTDurationInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeDuration)},
            {typeof(DTFloatInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeFloat)},
            {typeof(DTIntegerInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeInteger)},
            {typeof(DTLongInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeLong)},
            {typeof(DTStringInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeString)},
            {typeof(DTTimeInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeTime)}
        };

        // Frequently used nodes
        private static readonly IUriNode _shIri = _shapesGraph.CreateUriNode(SH.IRI);

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options => 
                {
                    _inputPath = options.InputPath;
                    _outputPath = options.OutputPath;
                    _namespaceMappingsPath = options.NamespaceMappingsPath;
                })
                .WithNotParsed(errors =>
                {
                    Environment.Exit(1);
                });
            
            _ontology = LoadInput();

            // Load namespace mappings
            using (var reader = new StreamReader(_namespaceMappingsPath))
            {
                string namespaceMappingsCsv = reader.ReadToEnd();
                string[] mappingRows = namespaceMappingsCsv.Split(Environment.NewLine);
                // Skipping first row b/c headers
                for (int i = 1; i < mappingRows.Length; i++)
                {
                    string mappingRow = mappingRows[i];
                    // Last line of file might be empty
                    if (mappingRow.Length == 0) continue;
                    // Use of semicolon b/c Swedish locale mandates it for CSV
                    string[] mappingRowComponents = mappingRow.Split(';');
                    string dtmiBase = mappingRowComponents[0];
                    string uriBase = mappingRowComponents[1];
                    string prefix = mappingRowComponents[2];

                    _dtmiBaseToUriBase.Add(dtmiBase, uriBase);
                    _shapesGraph.NamespaceMap.AddNamespace(prefix, new Uri(uriBase));
                }
            }

            foreach (DTInterfaceInfo iface in _ontology.Values
                .Where(entity => entity is DTInterfaceInfo)
                .Select(entity => (DTInterfaceInfo)entity))
            {
                // Create a new NodeShape
                NodeShape nodeShape = _shapesGraph.CreateNodeShape(GetShaclId(iface.Id));

                // Add labels and comments from DTDL display names and descriptions
                foreach ((string lang, string val) in iface.DisplayName) {
                    nodeShape.AddLabel(lang, val);
                }
                foreach ((string lang, string val) in iface.Description) {
                    nodeShape.AddComment(lang, val);
                }

                // Assert superclasses
                foreach (DTInterfaceInfo parentIface in iface.Extends) {
                    IUriNode parentNode = _shapesGraph.CreateUriNode(GetShaclId(parentIface.Id));
                    nodeShape.AddSuperClass(parentNode);
                }

                // Translate DTDL properties
                foreach (DTPropertyInfo property in iface.GetProperties()) {
                    PropertyShape pShape = nodeShape.CreatePropertyShape(GetShaclId(property.Id));

                    // Add SHACL names and descriptions from DTDL display names and descriptions
                    foreach ((string lang, string val) in property.DisplayName) {
                        pShape.AddName(lang, val);
                    }
                    foreach ((string lang, string val) in property.Description) {
                        pShape.AddDescription(lang, val);
                    }
                    
                    // Property schema translation (recursive if needed for, maps, arrays, etc.)
                    BuildPropertyShape(pShape, property.Schema, property.Name);
                }

                // Translate DTDL Relationships
                foreach (DTRelationshipInfo relationship in iface.GetRelationships()) {
                    PropertyShape pShape = nodeShape.CreatePropertyShape(GetShaclId(relationship.Id));
                    pShape.NodeKind = _shIri;
                    if (relationship.Target != null) {
                        pShape.AddClass(GetShaclId(relationship.Target));
                    }
                    // Add SHACL names and descriptions from DTDL display names and descriptions
                    foreach ((string lang, string val) in relationship.DisplayName) {
                        pShape.AddName(lang, val);
                    }
                    foreach ((string lang, string val) in relationship.Description) {
                        pShape.AddDescription(lang, val);
                    }
                    // Multiplicity
                    pShape.MinCount = relationship.MinMultiplicity;
                    pShape.MaxCount = relationship.MaxMultiplicity;
                    // TODO: Properties on relationships (or ignore?)
                }

                // Translate DTDL Components
                foreach (DTComponentInfo component in iface.GetComponents()) {
                    PropertyShape pShape = nodeShape.CreatePropertyShape(GetShaclId(component.Id));
                    pShape.NodeKind = _shIri;
                    pShape.MaxCount = 1;
                    Uri schemaShaclUri = GetShaclId(component.Schema.Id);
                    pShape.AddClass(schemaShaclUri);
                    // In the SHACL output we indicate the preference for the schema NodeShape to be treated 
                    // as a component by co-typing it with the DTDL Component DTMI.
                    IUriNode schemaNode = _shapesGraph.CreateUriNode(schemaShaclUri);
                    IUriNode rdfType = _shapesGraph.CreateUriNode(RDF.type);
                    IUriNode dtdlComponent = _shapesGraph.CreateUriNode(UriFactory.Create("dtmi:dtdl:class:Component"));
                    _shapesGraph.Assert(schemaNode, rdfType, dtdlComponent);
                    // Add SHACL names and descriptions from DTDL display names and descriptions
                    foreach ((string lang, string val) in component.DisplayName) {
                        pShape.AddName(lang, val);
                    }
                    foreach ((string lang, string val) in component.Description) {
                        pShape.AddDescription(lang, val);
                    }
                }
            }

            var writer = new CompressingTurtleWriter() {
                PrettyPrintMode = true,
                CompressionLevel = WriterCompressionLevel.High
            };
            _shapesGraph.NamespaceMap.AddNamespace("sh", new Uri("http://www.w3.org/ns/shacl#"));
            writer.Save(_shapesGraph, _outputPath);
        }

        // Load a file or a directory of files from disk
        private static IReadOnlyDictionary<Dtmi, DTEntityInfo> LoadInput()
        {
            // Get selected file or, if directory selected, all JSON files in selected dir
            IEnumerable<FileInfo> sourceFiles;
            if (File.GetAttributes(_inputPath) == FileAttributes.Directory)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_inputPath);
                sourceFiles = directoryInfo.EnumerateFiles("*.json", SearchOption.AllDirectories);
            }
            else
            {
                FileInfo singleSourceFile = new FileInfo(_inputPath);
                sourceFiles = new[] { singleSourceFile };
            }

            List<string> modelJson = new List<string>();
            foreach (FileInfo file in sourceFiles)
            {
                using StreamReader modelReader = new StreamReader(file.FullName);
                modelJson.Add(modelReader.ReadToEnd());
            }
            ModelParser modelParser = new ModelParser(0);

            try
            {
                return modelParser.Parse(modelJson);
            }
            catch (ParsingException parserEx)
            {
                Console.Error.WriteLine(parserEx.Message);
                Console.Error.WriteLine(string.Join("\n\n", parserEx.Errors.Select(error => error.Message)));
                Environment.Exit(1);
                return null;
            }
        }

        private static void BuildPropertyShape(PropertyShape pShape, DTSchemaInfo schema, string name) {
            switch (schema) {
                case DTEnumInfo enm:
                    DTPrimitiveSchemaInfo enumValueType = enm.ValueSchema;
                    IEnumerable<object> enumValues = enm.EnumValues.Select(enumValueInfo => enumValueInfo.EnumValue);
                    foreach (object enumValue in enumValues) {
                        ILiteralNode inNode;
                        if (enumValueType is DTStringInfo) {
                            inNode = ((string)enumValue).ToLiteral(_shapesGraph);
                        }
                        else {
                            inNode = ((int)enumValue).ToLiteral(_shapesGraph);
                        }
                        pShape.AddIn(inNode);
                    }
                    break;
                case DTComplexSchemaInfo complexSchema:
                    string complexSchemaShapeName = name[0].ToString().ToUpper() + name.Substring(1) + "Shape";
                    Uri complexSchemaShapeId = GetShaclId(schema.Id, complexSchemaShapeName);
                    IUriNode? complexSchemaShapeNode = _shapesGraph.GetUriNode(complexSchemaShapeId);
                    if (complexSchemaShapeNode == null) {
                        NodeShape complexSchemaShape = NodeShapeFromComplexSchema(complexSchemaShapeId, complexSchema, complexSchemaShapeName);
                    }
                    pShape.AddNode(complexSchemaShapeId);
                    break;
                default:
                    pShape.AddDatatype(_dtdlSchemaToXsd[schema.GetType()]);
                    pShape.MaxCount = 1;
                    break;
            }
        }

        private static NodeShape NodeShapeFromComplexSchema(Uri nodeShapeId, DTComplexSchemaInfo schema, string name) {
            NodeShape outputShape = _shapesGraph.CreateNodeShape(nodeShapeId);
            foreach ((string lang, string val) in schema.DisplayName) {
                outputShape.AddLabel(lang, val);
            }
            foreach ((string lang, string val) in schema.Description) {
                outputShape.AddComment(lang, val);
            }
            switch (schema) {
                case DTArrayInfo array:

                    PropertyShape firstShape = outputShape.CreatePropertyShape(RDF.first);
                    if (array.ElementSchema is DTComplexSchemaInfo) {
                        BuildPropertyShape(firstShape, array.ElementSchema, name.Replace("Shape","Entry"));
                        firstShape.MaxCount = 1;
                    }
                    else {
                        BuildPropertyShape(firstShape, array.ElementSchema, string.Empty);
                    }
                    
                    PropertyShape restShape = outputShape.CreatePropertyShape(RDF.rest);
                    restShape.MaxCount = 1;
                    IUriNode rdfNil = _shapesGraph.CreateUriNode(RDF.nil);
                    restShape.AddIn(outputShape.Node);
                    restShape.AddIn(rdfNil);
                    break;
                case DTObjectInfo obj:
                    foreach (DTFieldInfo field in obj.Fields) {
                        Uri path = GetShaclId(field.Id, field.Name);
                        PropertyShape pShape = outputShape.CreatePropertyShape(path);
                        BuildPropertyShape(pShape, field.Schema, field.Name);
                    }
                    break;
                case DTMapInfo map:
                    PropertyShape keyShape = outputShape.CreatePropertyShape(GetShaclId(map.Id,map.MapKey.Name));
                    keyShape.AddDatatype(UriFactory.Create(XmlSpecsHelper.XmlSchemaDataTypeString));
                    keyShape.MaxCount = 1;

                    PropertyShape valueShape = outputShape.CreatePropertyShape(GetShaclId(map.Id,map.MapValue.Name));
                    BuildPropertyShape(valueShape, map.MapValue.Schema, map.MapValue.Name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(schema), "Only schemas of type DTArrayInfo, DTObjectInfo, or DTMapInfo can be translated into SHACL NodeShapes.");
            }
            return outputShape;
        }

        private static Uri GetShaclId(Dtmi dtmiRoot, string localName) {
            foreach ((string dtmiBase, string uriBase) in _dtmiBaseToUriBase) {
                if (dtmiRoot.AbsoluteUri.Contains(dtmiBase)) {
                    return new Uri(uriBase + localName);
                }
            }
            return new Uri(dtmiRoot.ToString() + localName);
        }

        private static Uri GetShaclId(Dtmi dtmi) {
            string versionLessDtmi = dtmi.Versionless;
            string localName =  versionLessDtmi.Split(':').Last();
            if (dtmi.IsReserved) {
                localName = localName.Trim('_');
            }

            foreach ((string dtmiBase, string uriBase) in _dtmiBaseToUriBase) {
                if (versionLessDtmi.Contains(dtmiBase)) {
                    return new Uri(uriBase + localName);
                }
            }

            // Fall-back to returning DTMI
            return dtmi;
        }
    }
}