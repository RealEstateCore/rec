using CommandLine;
using DotNetRdfExtensions.SHACL;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;
using VDS.RDF;
using VDS.RDF.Ontology;
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

        // ID translation machinery
        private static Dictionary<string,string> _dtmiBaseToUriBase = new();

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
                    
                    // TODO: Property schema translation
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
                PrettyPrintMode = true
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