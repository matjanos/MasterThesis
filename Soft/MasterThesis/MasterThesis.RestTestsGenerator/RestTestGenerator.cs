using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
using MasterThesis.RestTestsGenerator.UnitTestWriters;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using NLog;
using Raml.Parser;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator
{
    public class RestTestGenerator
    {
        private RamlDocument ramlDocument;
        private readonly RamlParser ramlParser;
        private readonly string filePath;
        private readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public RestTestGenerator(string inputFile)
        {
            filePath = Path.GetFullPath(inputFile);
            ramlParser = new RamlParser();
            if (!File.Exists(filePath))
            {
                Log.Error("Loading RAML file error. File {0} doesn't exist", filePath);
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

        public void GenerateTest(IUnitTestWriter unitTestWriter, IIntermidiateCodeGenerator intermidiateCodeGenerator, IUseCaseBuilder useCaseBuilder)
        {
            intermidiateCodeGenerator.WriteDocumentStart();

            foreach (var resource in ramlDocument.Resources)
            {
                intermidiateCodeGenerator.WriteResourceUseCases(resource,
                    ramlDocument.Schemas.SingleOrDefault(x => x.ContainsKey(resource.DisplayName)), 
                    ramlDocument.BaseUri,
                    useCaseBuilder);
            }

            intermidiateCodeGenerator.WriteDocumentEnd();
        }
    }
}
