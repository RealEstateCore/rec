using CommandLine;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DTDL2MD
{
    internal class Program
    {
        public class Options
        {
            [Option('i', "inputPath", Required = true, HelpText = "The path to the ontology root directory or file to translate.")]
            public string InputPath { get; set; } = "";
            [Option('o', "outputPath", Required = true, HelpText = "The path at which to put the generated Markdown files.")]
            public string OutputPath { get; set; } = "";
        }

        // Configuration fields
        private static string inputRoot = string.Empty;
        private static string outputRoot = string.Empty;

        // Data fields
        private static IReadOnlyDictionary<Dtmi, DTEntityInfo> ontology = new ReadOnlyDictionary<Dtmi, DTEntityInfo>(new Dictionary<Dtmi, DTEntityInfo>());

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed(o =>
                   {
                       inputRoot = o.InputPath;
                       // Ensure exactly ONE trailing slash on output path, regardless of whether user entered one or not.
                       outputRoot = o.OutputPath.TrimEnd('/') + "/";
                   })
                   .WithNotParsed((errs) =>
                   {
                       Environment.Exit(1);
                   });

            if (!((File.Exists(inputRoot) || Directory.Exists(inputRoot)) && Directory.Exists(outputRoot))) 
            {
                Console.Error.WriteLine("Input and/or output paths do not exist.");
                Environment.Exit(1); 
            }
            LoadInput();

            foreach (DTInterfaceInfo iface in ontology.Values.Where(entity => entity is DTInterfaceInfo))
            {
                List<string> output = new List<string>();

                string ifaceName = GetApiName(iface);

                // Ancestor breadcrumbs
                List<string> ancestorLinks = new List<string>();
                Uri ifacePath = new Uri($"file:///{outputRoot}{GetPath(iface)}");
                Uri indexPathUri = new Uri($"file:///{outputRoot}index.md");
                Uri linkToIndex = ifacePath.MakeRelativeUri(indexPathUri);
                ancestorLinks.Add($"[Index]({linkToIndex.OriginalString})");
                foreach (DTInterfaceInfo ancestor in GetLongestParentPath(iface))
                {
                    ancestorLinks.Add($"[{GetApiName(ancestor)}]({GetRelativePath(iface, ancestor)})");
                }
                ancestorLinks.Add($"[{ifaceName}](#)");
                output.Add(string.Join(" > ", ancestorLinks));

                // Page title, description, displayname, and DTMI
                output.Add($"# {ifaceName}\n");

                if (iface.Description.Count > 0)
                {
                    output.Add($"{iface.Description.First().Value}\n\n");
                }
                if (iface.DisplayName.Count > 0)
                {
                    output.Add($"**Display name:** {iface.DisplayName.First().Value}<br />");
                }
                output.Add($"**DTMI:** {iface.Id}");

                // Child interfaces section
                if (ontology.ChildrenOf(iface).Any())
                {
                    output.Add("\n---\n");
                    output.Add("## Child interfaces");
                    foreach (DTInterfaceInfo childIface in ontology.ChildrenOf(iface))
                    {
                        output.Add($"* [{GetApiName(childIface)}]({GetRelativePath(iface, childIface)})");
                    }
                }

                // Components section
                if (iface.AllComponents().Any())
                {
                    output.Add("\n---\n");
                    output.Add("## Components\n");
                    if (iface.DirectComponents().Any())
                    {
                        output.Add("|Name|Display name|Description|Schema|");
                        output.Add("|-|-|-|-|");
                    }
                    foreach (DTComponentInfo component in iface.DirectComponents())
                    {
                        string name = component.Name;
                        string dname = string.Join("<br />", component.DisplayName.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string desc = string.Join("<br />", component.Description.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string schema = component.Schema == null ? "" : $"[{GetApiName(component.Schema)}]({GetRelativePath(iface, component.Schema)})";
                        output.Add($"|{name}|{dname}|{desc}|{schema}|");
                    }
                    if (iface.InheritedComponents().Any())
                    {
                        output.Add("### Inherited Components");
                        foreach (Dtmi parent in iface.InheritedComponents().Select(ic => ic.DefinedIn).Distinct())
                        {
                            string components = string.Join(", ", iface.InheritedComponents().Where(ic => ic.DefinedIn == parent).Select(ic => ic.Name).OrderBy(icName => icName));
                            string parentLink = $"[{GetApiName(ontology[parent])}]({GetRelativePath(iface, parent)})";
                            output.Add($"* **{parentLink}:** {components}");
                        }
                    }
                }

                // Relationships section
                if (iface.AllRelationships().Any()) {
                    output.Add("\n---\n");
                    output.Add("## Relationships\n");
                    if (iface.DirectRelationships().Any()) { 
                        output.Add("|Name|Display name|Description|Multiplicity|Target|Properties|Writable|");
                        output.Add("|-|-|-|-|-|-|-|");
                    }
                    foreach (DTRelationshipInfo relationship in iface.DirectRelationships())
                    {
                        string name = relationship.Name;
                        string dname = string.Join("<br />", relationship.DisplayName.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string desc = string.Join("<br />", relationship.Description.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string min = relationship.MinMultiplicity.HasValue ? relationship.MinMultiplicity.Value.ToString() : "0";
                        string max = relationship.MaxMultiplicity.HasValue ? relationship.MaxMultiplicity.Value.ToString() : "Infinity";
                        string multiplicity = $"{min}-{max}";
                        string target = relationship.Target == null ? "" : $"[{GetApiName(ontology[relationship.Target])}]({GetRelativePath(iface, relationship.Target)})";
                        string props = string.Join("<br>", relationship.Properties.Select(prop => $"{prop.Name} ({GetSchemaString(prop.Schema)})"));
                        bool writable = relationship.Writable;
                        output.Add($"|{name}|{dname}|{desc}|{multiplicity}|{target}|{props}|{writable}|");
                    }
                    if (iface.InheritedRelationships().Any())
                    {
                        output.Add("### Inherited Relationships");
                        foreach (Dtmi parent in iface.InheritedRelationships().Select(ir => ir.DefinedIn).Distinct())
                        {
                            string relationships = string.Join(", ", iface.InheritedRelationships().Where(ir => ir.DefinedIn == parent).Select(ir => ir.Name).OrderBy(irName => irName));
                            string parentLink = $"[{GetApiName(ontology[parent])}]({GetRelativePath(iface, parent)})";
                            output.Add($"* **{parentLink}:** {relationships}");
                        }
                    }
                }

                // Properties section
                if (iface.AllProperties().Any()) {
                    output.Add("\n---\n");
                    output.Add("## Properties\n");
                    if (iface.DirectProperties().Any()) { 
                        output.Add("|Name|Display name|Description|Schema|Writable|");
                        output.Add("|-|-|-|-|-|");
                    }
                    foreach (DTPropertyInfo property in iface.DirectProperties()) {
                        string name = property.Name;
                        string dname = string.Join("<br />", property.DisplayName.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string desc = string.Join("<br />", property.Description.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        bool writable = property.Writable;
                        string schema = GetSchemaString(property.Schema);
                        output.Add($"|{name}|{dname}|{desc}|{schema}|{writable}|");
                    }
                    if (iface.InheritedProperties().Any())
                    {
                        output.Add("### Inherited Properties");
                        foreach (Dtmi parent in iface.InheritedProperties().Select(ip => ip.DefinedIn).Distinct())
                        {
                            string properties = string.Join(", ", iface.InheritedProperties().Where(ip => ip.DefinedIn == parent).Select(ip => ip.Name).OrderBy(ipName => ipName));
                            string parentLink = $"[{GetApiName(ontology[parent])}]({GetRelativePath(iface, parent)})";
                            output.Add($"* **{parentLink}:** {properties}");
                        }
                    }
                }

                // Telemetries section
                if (iface.AllTelemetries().Any()) {
                    output.Add("\n---\n");
                    output.Add("## Telemetries\n");
                    if (iface.DirectTelemetries().Any())
                    {
                        output.Add("|Name|Display name|Description|Schema");
                        output.Add("|-|-|-|-|");
                    }
                    foreach (DTTelemetryInfo telemetry in iface.DirectTelemetries())
                    {
                        string name = telemetry.Name;
                        string dname = string.Join("<br />", telemetry.DisplayName.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string desc = string.Join("<br />", telemetry.Description.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string schema = GetSchemaString(telemetry.Schema);
                        output.Add($"|{name}|{dname}|{desc}|{schema}|");
                    }
                    if (iface.InheritedTelemetries().Any())
                    {
                        output.Add("### Inherited Telemetries");
                        foreach (Dtmi parent in iface.InheritedTelemetries().Select(it => it.DefinedIn).Distinct())
                        {
                            string telemetries = string.Join(", ", iface.InheritedTelemetries().Where(it => it.DefinedIn == parent).Select(it => it.Name).OrderBy(itName => itName));
                            string parentLink = $"[{GetApiName(ontology[parent])}]({GetRelativePath(iface, parent)})";
                            output.Add($"* **{parentLink}:** {telemetries}");
                        }
                    }
                }

                // Commands section
                if (iface.AllCommands().Any()) {
                    output.Add("\n---\n");
                    output.Add("## Commands\n");
                    if (iface.DirectCommands().Any())
                    {
                        output.Add("|Name|Display name|Description|Request schema|Response Schema|");
                        output.Add("|-|-|-|-|");
                    }
                    foreach (DTCommandInfo command in iface.DirectCommands())
                    {
                        string name = command.Name;
                        string dname = string.Join("<br />", command.DisplayName.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string desc = string.Join("<br />", command.Description.Select(kvp => $"**{kvp.Key}**: {kvp.Value}"));
                        string requestSchema = command.Request != null ? GetSchemaString(command.Request.Schema) : "";
                        string responseSchema = command.Response != null ? GetSchemaString(command.Response.Schema) : "";
                        output.Add($"|{name}|{dname}|{desc}|{requestSchema}|{responseSchema}|");
                    }
                    if (iface.InheritedCommands().Any())
                    {
                        output.Add("### Inherited Commands");
                        foreach (Dtmi parent in iface.InheritedCommands().Select(ic => ic.DefinedIn).Distinct())
                        {
                            string commands = string.Join(", ", iface.InheritedCommands().Where(ic => ic.DefinedIn == parent).Select(ic => ic.Name).OrderBy(icName => icName));
                            string parentLink = $"[{GetApiName(ontology[parent])}]({GetRelativePath(iface, parent)})";
                            output.Add($"* **{parentLink}:** {commands}");
                        }
                    }
                }

                // Incoming Relationship links to this interface
                output.Add("\n---\n");
                output.Add("## Target Of");
                if (ontology.UntargetedRelationships().Any()) {
                    output.Add("### General");
                    foreach (DTRelationshipInfo relationship in ontology.UntargetedRelationships())
                    {
                        DTEntityInfo definedIn = ontology[relationship.DefinedIn];
                        output.Add($"* [{GetApiName(definedIn)}]({GetRelativePath(iface, relationship.DefinedIn)}).{relationship.Name}");
                    }
                }

                if (ontology.RelationshipsTargeting(iface.Id).Any())
                {
                    output.Add("### Direct");
                    foreach (DTRelationshipInfo relationship in ontology.RelationshipsTargeting(iface.Id))
                    {
                        DTEntityInfo definedIn = ontology[relationship.DefinedIn];
                        output.Add($"* [{GetApiName(definedIn)}]({GetRelativePath(iface, relationship.DefinedIn)}).{relationship.Name}");
                    }
                }

                // Incoming Relationship links to parent interfaces
                IEnumerable<Dtmi> parentDtmis = iface.AllParents().Select(parent => parent.Id);
                if (ontology.RelationshipsTargeting(parentDtmis).Any())
                {
                    output.Add($"### Inherited");
                    foreach (DTRelationshipInfo indirectRelationship in ontology.RelationshipsTargeting(parentDtmis))
                    {
                        DTEntityInfo definedIn = ontology[indirectRelationship.DefinedIn];
                        output.Add($"* [{GetApiName(definedIn)}]({GetRelativePath(iface, indirectRelationship.DefinedIn)}).{indirectRelationship.Name}");
                    }
                }

                // Define and create output directory; write file and log
                string outputFilePath = outputRoot + GetPath(iface);
                if (Path.GetDirectoryName(outputFilePath) is string outputDirectoryPath) {
                    Directory.CreateDirectory(outputDirectoryPath);
                }
                File.WriteAllLines(outputFilePath, output);
                Console.WriteLine($"Wrote {outputFilePath}");
            }

            // Write full index page
            Console.WriteLine($"Generating full index...");
            List<string> fullIndexPage = new List<string>();
            fullIndexPage.Add("# Full Type Index\n");
            foreach (DTInterfaceInfo iface in ontology.Values.Where(entity => entity is DTInterfaceInfo iface && !iface.Extends.Any()).OrderBy(iface => GetApiName(iface)))
            {
                RecursivelyWriteTree(iface, 0, fullIndexPage);
            }
            string fullIndexPath = outputRoot + "index.full.md";
            File.WriteAllLines(fullIndexPath, fullIndexPage);
        }

        private static void RecursivelyWriteTree(DTInterfaceInfo iface, int nestingLevel, List<string> indexPage)
        {
            int paddingCount = nestingLevel * 4;
            string padding = "".PadLeft(paddingCount, ' ');
            string ifaceName = GetApiName(iface);
            string link = GetPath(iface);
            string line = $"{padding}* [{ifaceName}]({link})";
            indexPage.Add(line);
            foreach (DTInterfaceInfo childIface in ontology.ChildrenOf(iface).OrderBy(child => GetApiName(child)))
            {
                RecursivelyWriteTree(childIface, nestingLevel + 1, indexPage);
            }
        }

        private static string GetSchemaString(DTSchemaInfo schema)
        {
            switch (schema)
            {
                case DTBooleanInfo:
                    return "boolean";
                case DTDateInfo:
                    return "date";
                case DTDateTimeInfo:
                    return "dateTime";
                case DTDoubleInfo:
                    return "double";
                case DTDurationInfo:
                    return "duration";
                case DTFloatInfo:
                    return "float";
                case DTIntegerInfo:
                    return "integer";
                case DTLongInfo:
                    return "long";
                case DTStringInfo:
                    return "string";
                case DTTimeInfo:
                    return "time";
                case DTMapInfo map:
                    string mapKeySchema = GetSchemaString(map.MapKey.Schema);
                    string mapValueSchema = GetSchemaString(map.MapValue.Schema);
                    return $"map ({mapKeySchema}->{mapValueSchema})";
                case DTArrayInfo array:
                    string arrayElementSchema = GetSchemaString(array.ElementSchema);
                    return $"array ({arrayElementSchema})";
                case DTEnumInfo enumSchema:
                    string enumOptions = string.Join(", ",enumSchema.EnumValues.Select(enumValue => enumValue.Name));
                    return $"enum ({enumOptions})";
                /*case DTObjectInfo objectSchema:
                    string objectFields = string.Join(", ",objectSchema.Fields.Select(field => $"{field.Name} ({GetSchemaString(field.Schema)})"));
                    return $"object ({objectFields})";*/
                default:
                    return schema.ToString() ?? schema.Id.ToString();
            }
        }

        private static string GetPath(DTInterfaceInfo iface)
        {
            // Construct parent directory structure based on longest parent path to root
            string ifaceName = GetApiName(iface);
            List<DTInterfaceInfo> parentDirectories = GetLongestParentPath(iface);
            string outputDirectory = string.Join("/", parentDirectories.Select(parent => GetApiName(parent)));
            // If non-root output directory, add trailing slash
            if (outputDirectory.Length > 0 )
            {
                outputDirectory += "/";
            }
            
            // If the interface has children, place it with them
            if (ontology.ChildrenOf(iface).Any()) {
                outputDirectory += $"{ifaceName}/";
            }
            
            string outputFilePath = outputDirectory + $"{ifaceName}.md";

            return outputFilePath;
        }

        private static string GetRelativePath(DTInterfaceInfo sourceIface, DTInterfaceInfo targetIface)
        {
            if (sourceIface == targetIface)
            {
                return "#";
            }
            Uri sourcePath = new Uri($"file:///{outputRoot}{GetPath(sourceIface)}");
            Uri targetPath = new Uri($"file:///{outputRoot}{GetPath(targetIface)}");
            Uri relativeLink = sourcePath.MakeRelativeUri(targetPath);
            return relativeLink.OriginalString;
        }

        private static string GetRelativePath(DTInterfaceInfo sourceIface, Dtmi targetDtmi)
        {
            DTInterfaceInfo targetIface = (DTInterfaceInfo)ontology[targetDtmi];
            return GetRelativePath(sourceIface, targetIface);
        }

        private static List<DTInterfaceInfo> GetLongestParentPath(DTInterfaceInfo iface)
        {
            // If we have no superclass, then we have reached the top level; return
            if (iface.Extends.Count < 1)
            {
                return new List<DTInterfaceInfo>();
            }
            else
            {
                // Assume the first parent has the longest path; if not, it will be replaced in subsequent foreach
                DTInterfaceInfo longestParent = iface.Extends[0];
                List<DTInterfaceInfo> longestParentPath = GetLongestParentPath(longestParent);

                // Iterate through the other parents to see if any is longer
                foreach (DTInterfaceInfo possibleSuperClass in iface.Extends.Skip(1))
                {
                    List<DTInterfaceInfo> possibleSuperClassParents = GetLongestParentPath(possibleSuperClass);
                    if (possibleSuperClassParents.Count > longestParentPath.Count)
                    {
                        longestParent = possibleSuperClass;
                        longestParentPath = possibleSuperClassParents;
                    }
                }

                // At this point longestParentPath + longestParent should together contain the longest path to the root; return them
                longestParentPath.Add(longestParent);
                return longestParentPath;
            }
        }

        private static string GetApiName(DTEntityInfo entityInfo)
        {
            if (entityInfo is DTNamedEntityInfo)
                return ((DTNamedEntityInfo)entityInfo).Name;

            string versionLessDtmi = entityInfo.Id.Versionless;
            string entityNamespace = versionLessDtmi.Substring(0, versionLessDtmi.LastIndexOf(':'));
            string entityId = versionLessDtmi.Substring(versionLessDtmi.LastIndexOf(':') + 1);

            return versionLessDtmi.Split(':').Last();
        }

        // Load a file or a directory of files from disk
        private static void LoadInput()
        {
            // Get selected file or, if directory selected, all JSON files in selected dir
            IEnumerable<FileInfo> sourceFiles;
            if (File.GetAttributes(inputRoot) == FileAttributes.Directory)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(inputRoot);
                sourceFiles = directoryInfo.EnumerateFiles("*.json", SearchOption.AllDirectories);
            }
            else
            {
                FileInfo singleSourceFile = new FileInfo(inputRoot);
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
                ontology = modelParser.Parse(modelJson);
            }
            catch (ParsingException parserEx)
            {
                Console.Error.WriteLine(parserEx.Message);
                Console.Error.WriteLine(string.Join("\n\n", parserEx.Errors.Select(error => error.Message)));
                Environment.Exit(1);
            }
        }
    }
}