// <copyright file="Program.cs" company="RealEstateCore Consortium">
// Copyright (c) RealEstateCore Consortium. All rights reserved.
// </copyright>

namespace DTDL2SHACL
{
    using System.Xml;
    using CommandLine;
    using Microsoft.Azure.DigitalTwins.Parser;
    using Microsoft.Azure.DigitalTwins.Parser.Models;
    using RealEstateCore.DotNetRdfExtensions;
    using RealEstateCore.DotNetRdfExtensions.SHACL;
    using VDS.RDF;
    using VDS.RDF.Ontology;
    using VDS.RDF.Parsing;
    using VDS.RDF.Shacl;
    using VDS.RDF.Writing;

    /// <summary>
    /// Program translating a DTDL ontology into the RDF Shapes Constraint Language (SHACL).
    /// </summary>
    internal class Program
    {
        // DT schema translation
        private static readonly Dictionary<Type, Uri> DtdlSchemaToXsd = new ()
        {
            { typeof(DTBooleanInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeBoolean) },
            { typeof(DTDateInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeDate) },
            { typeof(DTDateTimeInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeTime) },
            { typeof(DTDoubleInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeDouble) },
            { typeof(DTDurationInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeDuration) },
            { typeof(DTFloatInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeFloat) },
            { typeof(DTIntegerInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeInteger) },
            { typeof(DTLongInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeLong) },
            { typeof(DTStringInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeString) },
            { typeof(DTTimeInfo), new Uri(XmlSpecsHelper.XmlSchemaDataTypeTime) },
        };

        // Configuration fields
        private static string inputPath = string.Empty;
        private static string outputPath = string.Empty;
        private static string namespaceMappingsPath = string.Empty;
        private static string nuspecPath = string.Empty;

        // Data fields
        private static IReadOnlyDictionary<Dtmi, DTEntityInfo>? ontology;
        private static OntologyGraph ontologyGraph = new OntologyGraph();
        private static ShapesGraph shapesGraph = new (ontologyGraph);
        private static Ontology? outputOntology;

        // ID translation
        private static Dictionary<string, string> dtmiBaseToUriBase = new ();

        // Frequently used nodes
        private static IUriNode shIri = shapesGraph.CreateUriNode(SH.IRI);

        /// <summary>
        /// Program entrance point.
        /// </summary>
        /// <param name="args">Argument vector.</param>
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                {
                    inputPath = options.InputPath;
                    outputPath = options.OutputPath;
                    namespaceMappingsPath = options.NamespaceMappingsPath;
                    nuspecPath = options.NuspecPath;
                })
                .WithNotParsed(errors =>
                {
                    Environment.Exit(1);
                });

            ontology = LoadInput();

            // Load namespace mappings
            using (var reader = new StreamReader(namespaceMappingsPath))
            {
                string namespaceMappingsCsv = reader.ReadToEnd();
                string[] mappingRows = namespaceMappingsCsv.Split(Environment.NewLine);

                // Skipping first row b/c headers
                for (int i = 1; i < mappingRows.Length; i++)
                {
                    string mappingRow = mappingRows[i];

                    // Last line of file might be empty
                    if (mappingRow.Length == 0)
                    {
                        continue;
                    }

                    // Use of semicolon b/c Swedish locale mandates it for CSV
                    string[] mappingRowComponents = mappingRow.Split(';');
                    string dtmiBase = mappingRowComponents[0];
                    string uriBase = mappingRowComponents[1];
                    string prefix = mappingRowComponents[2];

                    // First mapping entry is set as target graph base URI.
                    if (i == 1)
                    {
                        ontologyGraph.BaseUri = new Uri(uriBase.TrimEnd(new char[] { '#', '/' }));
                    }

                    dtmiBaseToUriBase.Add(dtmiBase, uriBase);
                    shapesGraph.NamespaceMap.AddNamespace(prefix, new Uri(uriBase));
                }
            }

            // Create owl:Ontology entity in the output ontologyGraph
            IUriNode ontologyNode = ontologyGraph.CreateUriNode(ontologyGraph.BaseUri);
            outputOntology = new Ontology(ontologyNode, ontologyGraph);

            if (!string.IsNullOrEmpty(nuspecPath))
            {
                ParseNuspec();
            }

            foreach (DTInterfaceInfo iface in ontology.Values
                .Where(entity => entity is DTInterfaceInfo)
                .Select(entity => (DTInterfaceInfo)entity))
            {
                // Create a new NodeShape
                NodeShape nodeShape = shapesGraph.CreateNodeShape(GetShaclId(iface.Id));
                IUriNode rdfType = shapesGraph.CreateUriNode(RDF.type);
                IUriNode owlThing = shapesGraph.CreateUriNode(OWL.Thing);
                shapesGraph.Assert(nodeShape.Node, rdfType, owlThing);

                // Add labels and comments from DTDL display names and descriptions
                foreach ((string lang, string val) in iface.DisplayName)
                {
                    nodeShape.AddLabel(lang, val);
                }

                foreach ((string lang, string val) in iface.Description)
                {
                    nodeShape.AddComment(lang, val);
                }

                // Assert superclasses
                foreach (DTInterfaceInfo parentIface in iface.Extends)
                {
                    IUriNode parentNode = shapesGraph.CreateUriNode(GetShaclId(parentIface.Id));
                    nodeShape.AddSuperClass(parentNode);
                }

                // Translate DTDL properties
                foreach (DTPropertyInfo property in iface.GetProperties())
                {
                    PropertyShape pShape = nodeShape.CreatePropertyShape(GetShaclId(property.Id));

                    // Add SHACL names and descriptions from DTDL display names and descriptions
                    foreach ((string lang, string val) in property.DisplayName)
                    {
                        pShape.AddName(lang, val);
                    }

                    foreach ((string lang, string val) in property.Description)
                    {
                        pShape.AddDescription(lang, val);
                    }

                    // Property schema translation (recursive if needed for, maps, arrays, etc.)
                    BuildPropertyShape(pShape, property.Schema, property.Name);
                }

                // Translate DTDL Relationships
                foreach (DTRelationshipInfo relationship in iface.GetRelationships())
                {
                    PropertyShape pShape = nodeShape.CreatePropertyShape(GetShaclId(relationship.Id));
                    pShape.NodeKind = shIri;
                    if (relationship.Target != null)
                    {
                        pShape.AddClass(GetShaclId(relationship.Target));
                    }

                    // Add SHACL names and descriptions from DTDL display names and descriptions
                    foreach ((string lang, string val) in relationship.DisplayName)
                    {
                        pShape.AddName(lang, val);
                    }

                    foreach ((string lang, string val) in relationship.Description)
                    {
                        pShape.AddDescription(lang, val);
                    }

                    // Multiplicity
                    pShape.MinCount = relationship.MinMultiplicity;
                    pShape.MaxCount = relationship.MaxMultiplicity;

                    // TODO: Properties on relationships (or ignore?)
                }

                // Translate DTDL Components
                foreach (DTComponentInfo component in iface.GetComponents())
                {
                    PropertyShape pShape = nodeShape.CreatePropertyShape(GetShaclId(component.Id));
                    pShape.NodeKind = shIri;
                    pShape.MaxCount = 1;
                    Uri schemaShaclUri = GetShaclId(component.Schema.Id);
                    pShape.AddClass(schemaShaclUri);

                    // In the SHACL output we indicate the preference for the schema NodeShape to be treated
                    // as a component by co-typing it with the DTDL Component DTMI.
                    IUriNode schemaNode = shapesGraph.CreateUriNode(schemaShaclUri);
                    IUriNode dtdlComponent = shapesGraph.CreateUriNode(UriFactory.Create("dtmi:dtdl:class:Component"));
                    shapesGraph.Assert(schemaNode, rdfType, dtdlComponent);

                    // Add SHACL names and descriptions from DTDL display names and descriptions
                    foreach ((string lang, string val) in component.DisplayName)
                    {
                        pShape.AddName(lang, val);
                    }

                    foreach ((string lang, string val) in component.Description)
                    {
                        pShape.AddDescription(lang, val);
                    }
                }
            }

            var writer = new CompressingTurtleWriter()
            {
                PrettyPrintMode = true,
                CompressionLevel = WriterCompressionLevel.High,
            };
            shapesGraph.NamespaceMap.AddNamespace("dc", new Uri("http://purl.org/dc/elements/1.1/"));
            shapesGraph.NamespaceMap.AddNamespace("sh", new Uri("http://www.w3.org/ns/shacl#"));
            shapesGraph.NamespaceMap.AddNamespace("cc", new Uri("http://creativecommons.org/ns#"));
            writer.Save(shapesGraph, outputPath);
        }

        // Load a file or a directory of files from disk
        private static IReadOnlyDictionary<Dtmi, DTEntityInfo> LoadInput()
        {
            // Get selected file or, if directory selected, all JSON files in selected dir
            IEnumerable<FileInfo> sourceFiles;
            if (File.GetAttributes(inputPath) == FileAttributes.Directory)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(inputPath);
                sourceFiles = directoryInfo.EnumerateFiles("*.json", SearchOption.AllDirectories);
            }
            else
            {
                FileInfo singleSourceFile = new FileInfo(inputPath);
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

        private static void ParseNuspec()
        {
            using var reader = new StreamReader(nuspecPath);
            using var xmlReader = XmlReader.Create(reader);

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlReader);
            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("nuspec", "http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd");
            if (doc.DocumentElement == null)
            {
                throw new FormatException("Nuspec file malformed; missing document root.");
            }
            else
            {
                XmlElement docRoot = doc.DocumentElement;

                XmlNode? idNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:id/text()", namespaces);
                XmlNode? versionNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:version/text()", namespaces);
                XmlNode? descriptionNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:description/text()", namespaces);
                XmlNode? authorsNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:authors/text()", namespaces);

                if (idNode == null || versionNode == null || descriptionNode == null || authorsNode == null)
                {
                    throw new FormatException("Missing one of the mandatory nuspec fields: id, version, description, or author.");
                }
                else
                {
                    string? idValue = idNode.Value;
                    string? versionValue = versionNode.Value;
                    string? descriptionValue = descriptionNode.Value;
                    string? authorsValue = authorsNode.Value;

                    if (idValue == null || versionValue == null || descriptionValue == null || authorsValue == null)
                    {
                        throw new FormatException("One of the mandatory nuspec fields lacks value content: id, version, description, or author.");
                    }
                    else
                    {
                        outputOntology!.AddLabel(idValue);
                        outputOntology!.AddVersionInfo(versionValue);
                        outputOntology!.AddComment(descriptionValue);
                        var authors = authorsValue.Split(',').Select(author => author.Trim());
                        Uri dcCreatorUri = new Uri("http://purl.org/dc/elements/1.1/creator");
                        foreach (string author in authors)
                        {
                            outputOntology.AddLiteralProperty(dcCreatorUri, ontologyGraph.CreateLiteralNode(author, new Uri(XmlSpecsHelper.XmlSchemaDataTypeString)), true);
                        }

                        // Parse non-mandatory fields
                        XmlNode? titleNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:title/text()", namespaces);
                        if (titleNode != null && titleNode.Value != null)
                        {
                            // Title takes priority over ID when assigning name.
                            outputOntology.ClearLabels();
                            outputOntology.AddLabel(titleNode.Value);
                        }

                        XmlNode? licenseNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:license/text()", namespaces);
                        if (licenseNode != null && licenseNode.Value != null)
                        {
                            Uri ccLicense = new Uri("http://creativecommons.org/ns#license");
                            IUriNode license = ontologyGraph.CreateUriNode(new Uri($"https://opensource.org/licenses/{licenseNode.Value}"));
                            outputOntology.AddResourceProperty(ccLicense, license, true);
                        }

                        XmlNode? projectUrlNode = docRoot.SelectSingleNode("/nuspec:package/nuspec:metadata/nuspec:projectUrl/text()", namespaces);
                        if (projectUrlNode != null && projectUrlNode.Value != null)
                        {
                            outputOntology.AddSeeAlso(new Uri(projectUrlNode.Value));
                        }
                    }
                }
            }
        }

        private static void BuildPropertyShape(PropertyShape pShape, DTSchemaInfo schema, string name)
        {
            switch (schema)
            {
                case DTEnumInfo enm:
                    DTPrimitiveSchemaInfo enumValueType = enm.ValueSchema;
                    IEnumerable<object> enumValues = enm.EnumValues.Select(enumValueInfo => enumValueInfo.EnumValue);
                    foreach (object enumValue in enumValues)
                    {
                        ILiteralNode inNode;
                        if (enumValueType is DTStringInfo)
                        {
                            inNode = ((string)enumValue).ToLiteral(shapesGraph);
                        }
                        else
                        {
                            inNode = ((int)enumValue).ToLiteral(shapesGraph);
                        }

                        pShape.AddIn(inNode);
                    }

                    break;
                case DTComplexSchemaInfo complexSchema:
                    string complexSchemaShapeName = name[0].ToString().ToUpper() + name.Substring(1) + "Shape";
                    Uri complexSchemaShapeId = GetShaclId(schema.Id, complexSchemaShapeName);
                    IUriNode? complexSchemaShapeNode = shapesGraph.GetUriNode(complexSchemaShapeId);
                    if (complexSchemaShapeNode == null)
                    {
                        NodeShape complexSchemaShape = NodeShapeFromComplexSchema(complexSchemaShapeId, complexSchema, complexSchemaShapeName);
                    }

                    pShape.AddNode(complexSchemaShapeId);
                    break;
                default:
                    pShape.AddDatatype(DtdlSchemaToXsd[schema.GetType()]);
                    pShape.MaxCount = 1;
                    break;
            }
        }

        private static NodeShape NodeShapeFromComplexSchema(Uri nodeShapeId, DTComplexSchemaInfo schema, string name)
        {
            NodeShape outputShape = shapesGraph.CreateNodeShape(nodeShapeId);
            foreach ((string lang, string val) in schema.DisplayName)
            {
                outputShape.AddLabel(lang, val);
            }

            foreach ((string lang, string val) in schema.Description)
            {
                outputShape.AddComment(lang, val);
            }

            switch (schema)
            {
                case DTArrayInfo array:

                    PropertyShape firstShape = outputShape.CreatePropertyShape(RDF.first);
                    if (array.ElementSchema is DTComplexSchemaInfo)
                    {
                        BuildPropertyShape(firstShape, array.ElementSchema, name.Replace("Shape", "Entry"));
                        firstShape.MaxCount = 1;
                    }
                    else
                    {
                        BuildPropertyShape(firstShape, array.ElementSchema, string.Empty);
                    }

                    PropertyShape restShape = outputShape.CreatePropertyShape(RDF.rest);
                    restShape.MaxCount = 1;
                    IUriNode rdfNil = shapesGraph.CreateUriNode(RDF.nil);
                    restShape.AddIn(outputShape.Node);
                    restShape.AddIn(rdfNil);
                    break;
                case DTObjectInfo obj:
                    foreach (DTFieldInfo field in obj.Fields)
                    {
                        Uri path = GetShaclId(field.Id, field.Name);
                        PropertyShape pShape = outputShape.CreatePropertyShape(path);
                        BuildPropertyShape(pShape, field.Schema, field.Name);
                    }

                    break;
                case DTMapInfo map:
                    PropertyShape keyShape = outputShape.CreatePropertyShape(GetShaclId(map.Id, map.MapKey.Name));
                    keyShape.AddDatatype(UriFactory.Create(XmlSpecsHelper.XmlSchemaDataTypeString));
                    keyShape.MaxCount = 1;

                    PropertyShape valueShape = outputShape.CreatePropertyShape(GetShaclId(map.Id, map.MapValue.Name));
                    BuildPropertyShape(valueShape, map.MapValue.Schema, map.MapValue.Name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(schema), "Only schemas of type DTArrayInfo, DTObjectInfo, or DTMapInfo can be translated into SHACL NodeShapes.");
            }

            return outputShape;
        }

        private static Uri GetShaclId(Dtmi dtmiRoot, string localName)
        {
            foreach ((string dtmiBase, string uriBase) in dtmiBaseToUriBase)
            {
                if (dtmiRoot.AbsoluteUri.Contains(dtmiBase))
                {
                    return new Uri(uriBase + localName);
                }
            }

            return new Uri(dtmiRoot.ToString() + localName);
        }

        private static Uri GetShaclId(Dtmi dtmi)
        {
            string versionLessDtmi = dtmi.Versionless;
            string localName = versionLessDtmi.Split(':').Last();
            if (dtmi.IsReserved)
            {
                localName = localName.Trim('_');
            }

            foreach ((string dtmiBase, string uriBase) in dtmiBaseToUriBase)
            {
                if (versionLessDtmi.Contains(dtmiBase))
                {
                    return new Uri(uriBase + localName);
                }
            }

            // Fall-back to returning DTMI
            return dtmi;
        }

        /// <summary>
        /// Program options, parsed by <see cref="CommandLine.Parser"/>.
        /// </summary>
        public class Options
        {
            /// <summary>
            /// Gets or sets the path to the DTDL ontology root directory or file.
            /// </summary>
            [Option('i', "inputPath", Required = true, HelpText = "The path to the DTDL ontology root directory or file.")]
            public string InputPath { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the path to the output SHACL file.
            /// </summary>
            [Option('o', "outputPath", Required = true, HelpText = "The path to the output SHACL file.")]
            public string OutputPath { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the path to namespace mappings CSV file.
            /// </summary>
            [Option('m', "namespaceMappingsPath", Required = true, HelpText = "Path to namespace mappings CSV file.")]
            public string NamespaceMappingsPath { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the path to .nuspec file holding package annotations.
            /// </summary>
            [Option('n', "nuspecPath", Required = false, HelpText = "Path to .nuspec file holding package annotations detailing, e.g., version, license, etc.")]
            public string NuspecPath { get; set; } = string.Empty;
        }
    }
}