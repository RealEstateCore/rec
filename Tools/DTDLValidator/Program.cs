namespace DTDLValidator
{
    using CommandLine;
    using DTDLParser;
    using DTDLParser.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;

    class Program
    {
        public class Options
        {
            [Option('e', "extension", Default = "json", SetName = "normal", HelpText = "File extension of files to be processed.")]
            public string Extension { get; set; }

            [Option('d', "directory", SetName = "normal", HelpText = "Directory to search files in.")]
            public string Directory { get; set; }

            [Option('r', "recursive", Default = false, SetName = "normal", HelpText = "Search given directory (option -d) only (false) or subdirectories too (true)")]
            public bool Recursive { get; set; }

            [Option('f', "files", HelpText = "Input files to be processed. If -d option is also specified, these files are read in addition.")]
            public IEnumerable<string> InputFiles { get; set; }
        }

        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args)
              .WithParsed(RunOptions)
              .WithNotParsed(HandleParseError);
        }

        static void RunOptions(Options opts)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            string dtdlParserVersion = "<unknown>";
            foreach (Assembly a in assemblies)
            {
                if (a.GetName().Name.EndsWith("DigitalTwins.Parser"))
                    dtdlParserVersion = a.GetName().Version.ToString();
            }

            Console.WriteLine($"Simple DTDL Validator (dtdl parser library version {dtdlParserVersion})");

            DirectoryInfo dinfo = null;
            try
            {
                if(opts.Directory != null && opts.Directory != string.Empty)
                {
                    dinfo = new DirectoryInfo(opts.Directory);
                    Console.WriteLine($"Validating *.{opts.Extension} files in folder '{dinfo.FullName}'.\nRecursive is set to {opts.Recursive}\n");

                    if (dinfo.Exists == false)
                    {
                        throw new Exception($"Specified directory '{opts.Directory}' does not exist.");
                    }
                }

            } catch (Exception e)
            {
                Console.Error.WriteLine($"Error accessing the target directory '{opts.Directory}': \n{e.Message}.");
                Environment.Exit(1);
            }

            SearchOption searchOpt = opts.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var files = opts.InputFiles.ToList();
            
            if(dinfo!= null)
            {
                dinfo.EnumerateFiles($"*.{opts.Extension}", searchOpt).ToList().ForEach(file => files.Add(file.FullName));
            }
            
            if (files.Count() == 0)
            {
                Console.WriteLine("No matching files found. Exiting.");
                Environment.Exit(0);
            }
            
            var modelDict = new Dictionary<string, string>();
            int count = 0;
            string lastFile = "<none>";
            try
            {
                foreach (var file in files)
                {
                    StreamReader r = new StreamReader(file);
                    string dtdl = r.ReadToEnd(); 
                    r.Close();
                    modelDict.Add(file, dtdl);
                    lastFile = file;
                    count++;
                }
            } catch (Exception e)
            {
                Console.Error.WriteLine($"Could not read files. \nLast file read: {lastFile}\nError: \n{e.Message}.");
                Environment.Exit(1);
            }
            
            Console.WriteLine($"Read {count} files from specified directory.");
            int errJson = 0;
            foreach (string file in modelDict.Keys)
            {
                modelDict.TryGetValue(file, out string dtdl);
                try
                {
                    JsonDocument.Parse(dtdl);
                } catch (Exception e)
                {
                    Console.Error.WriteLine($"Invalid json found in file {file}.\nJson parser error \n{e.Message}.");
                    errJson++;
                }
            }
            
            if (errJson>0)
            {
                Console.Error.WriteLine($"Found  {errJson} Json parsing errors.");
                Environment.Exit(2);
            }
            
            Console.WriteLine($"Validated JSON for all files - now validating DTDL");
            List<string> modelList = modelDict.Values.ToList<string>();
            ModelParser modelParser = new ModelParser(new ParsingOptions { AllowUndefinedExtensions = true, DtmiResolver = new DtmiResolver(Resolver) });
                        
            try
            {
                IReadOnlyDictionary<Dtmi, DTEntityInfo> om = modelParser.ParseAsync(modelList.ToAsyncEnumerable()).GetAwaiter().GetResult();
                Console.WriteLine("");
                Console.WriteLine($"**********************************************");
                Console.WriteLine($"** Validated all files - Your DTDL is valid **");
                Console.WriteLine($"**********************************************");
                Console.WriteLine($"Found a total of {om.Keys.Count()} entities");
            }
            catch (ParsingException pe)
            {
                Console.Error.WriteLine($"*** Error parsing models");
                int derrcount = 1;
                foreach (ParsingError err in pe.Errors)
                {
                    Console.Error.WriteLine($"Error {derrcount}:");
                    Console.Error.WriteLine($"{err.Message}");
                    Console.Error.WriteLine($"Primary ID: {err.PrimaryID}");
                    Console.Error.WriteLine($"Secondary ID: {err.SecondaryID}");
                    Console.Error.WriteLine($"Property: {err.Property}\n");
                    derrcount++;
                }
            
                Environment.Exit(3);
            }
            catch (ResolutionException)
            {
                Console.Error.WriteLine("Could not resolve required references.");
                Environment.Exit(3);
            }
        }

        static IEnumerable<string> Resolver(IReadOnlyCollection<Dtmi> dtmis)
        {
            Console.Error.WriteLine($"*** Error parsing models. Missing:");
            foreach (Dtmi d in dtmis)
            {
                Console.Error.WriteLine($"  {d}");
            }

            return null;
        }

        static void HandleParseError(IEnumerable<Error> errs)
        {
            Console.Error.WriteLine($"Invalid command line.");
            foreach (Error e in errs)
            {
                Console.Error.WriteLine($"{e.Tag}: {e}");
            }            
        }
    }
}