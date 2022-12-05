using CommandLine;
using DotNetRdfExtensions.SHACL;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;
using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Shacl;
using VDS.RDF.Writing;

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
        }

        // Configuration fields
        private static string _inputPath = string.Empty;
        private static string _outputPath = string.Empty;

        // Data fields
        private static IReadOnlyDictionary<Dtmi, DTEntityInfo>? _ontology;
        private static readonly OntologyGraph _ontologyGraph = new OntologyGraph();
        private static readonly ShapesGraph _shapesGraph = new(_ontologyGraph);

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options => 
                {
                    _inputPath = options.InputPath;
                    _outputPath = options.OutputPath;
                })
                .WithNotParsed(errors =>
                {
                    Environment.Exit(1);
                });
            
            _ontology = LoadInput();

            foreach (DTInterfaceInfo iface in _ontology.Values
                .Where(entity => entity is DTInterfaceInfo)
                .Select(entity => (DTInterfaceInfo)entity)
                .OrderBy(iface => iface.GetDepth()))
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

                // Get the parent interfaces' NodeShape equivalents from the shapes graph and assign thet as supershape using rdf:subClassOf
                foreach (DTInterfaceInfo parentIface in iface.Extends) {    
                    NodeShape? parentNodeShape = _shapesGraph.NodeShapes().FirstOrDefault(parentShape => parentShape.Uri == GetShaclId(parentIface.Id));
                    if (parentNodeShape != null)
                    {
                        nodeShape.AddSuperClass(parentNodeShape);
                    }
                }
            }

            var writer = new CompressingTurtleWriter() {
                PrettyPrintMode = true,
                CompressionLevel = 0
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
            // TODO: Implement using prefix index
            string localName = dtmi.Versionless.Split(':').Last();
            return new Uri($"https://example.com/{localName}");
        }
    }
}