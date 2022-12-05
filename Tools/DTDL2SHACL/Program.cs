using CommandLine;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;

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
                .Select(entity => (DTInterfaceInfo)entity)) 
            {
                Console.WriteLine(iface.Id);
            }
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
    }
}