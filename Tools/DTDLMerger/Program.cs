using System.Linq;
using System.Text.Json;
using DTDLParser;
using DTDLParser.Models;

if (args.Length != 1)
{
    Console.Error.WriteLine("Path to DTDL directory missing. Program usage: dotnet run C:\\PATH\\TO\\DTDL-MODELS\\");
    Environment.Exit(1);
}

// Enumerate input files
string inputPath = args.First();
DirectoryInfo inputDirectory = new DirectoryInfo(inputPath);
IEnumerable<FileInfo> inputFiles = inputDirectory.EnumerateFiles($"*.json", SearchOption.AllDirectories);

// Read those files
List<string> modelJson = new List<string>();
foreach (FileInfo file in inputFiles)
{
    using StreamReader modelReader = new StreamReader(file.FullName);
    modelJson.Add(modelReader.ReadToEnd());
}

// Parse the files
ModelParser modelParser = new ModelParser(new ParsingOptions { AllowUndefinedExtensions = true });
IReadOnlyDictionary<Dtmi, DTEntityInfo> ontology = await modelParser.ParseAsync(modelJson.ToAsyncEnumerable());

// Set up JSON stream and write wrapper array
Utf8JsonWriter writer = new Utf8JsonWriter(Console.OpenStandardOutput(), new JsonWriterOptions { Indented = true });
writer.WriteStartArray();

// Iterate over all interfaces ordered by depth and ID, writing them to output JSON array
foreach (DTInterfaceInfo iFace in ontology.Values
    .Where(entity => entity is DTInterfaceInfo)
    .Select(iFace => (DTInterfaceInfo)iFace)
    .OrderBy(iFace => GetDepth(iFace))
    .ThenBy(iFace => iFace.Id))
{
    iFace.GetJsonLd().WriteTo(writer);
}

// Close and flush JSON writer, write to console
writer.WriteEndArray();
writer.Flush();

// Recursively get greatest depth of interface in Extends hierarchy
int GetDepth(DTInterfaceInfo iFace)
{
    if (iFace.Extends.Count == 0)
    {
        return 0;
    }

    int greatestParentDepth = 0;
    foreach (DTInterfaceInfo parent in iFace.Extends)
    {
        int parentDepth = GetDepth(parent);
        if (parentDepth > greatestParentDepth)
        {
            greatestParentDepth = parentDepth;
        }
    }

    return greatestParentDepth + 1;
}