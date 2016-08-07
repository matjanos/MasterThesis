using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using MasterThesis.Common.Helpers;
using NLog;
using Raml.Parser;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator
{
    public class RestTestGenerator
    {
        private const int MillisecondsTimeout = 1000;
        private RamlDocument ramlDocument;
        private readonly RamlParser ramlParser;
        private readonly string filePath;
        private readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public RestTestGenerator(string inputFile)
        {
            filePath = inputFile;
            ramlParser = new RamlParser();
            if (!File.Exists(inputFile))
            {
                Log.Error("Loading RAML file error. File {0} doesn't exist", inputFile);
                throw new ArgumentException("File doesn't exist");
            }
            Log.Error("Generator initialized");
        }

        public async Task<bool> LoadFile()
        {
            try
            {
                ramlDocument = await ramlParser.LoadAsync(filePath);
                Log.Info("File {0} loaded", filePath);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new FileLoadException("Can't load file.", e);
            }
        }

        public void GenerateTest(IUnitTestWriter unitTestWriter)
        {
            foreach (var resource in ramlDocument.Resources)
            {
                foreach (var method in resource.Methods)
                {
                    HttpMethod currentMethod;

                    if (!EnumHelper.TryGetEnumValueFromDescription<HttpMethod>(method.Verb, out currentMethod))
                    {
                        Log.Warn("Unknown method {0} for {1} resource. Skipping...");
                        continue;
                    }

                    Log.Info("Creating for {0}: {1}", method.Verb, method.Description);

                }
            }
        }
    }
}
