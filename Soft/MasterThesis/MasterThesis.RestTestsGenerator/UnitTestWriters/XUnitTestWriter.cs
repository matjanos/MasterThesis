using System.Collections.Generic;
using System.IO;
using System.Net;
using MasterThesis.RestTestsGenerator.UseCases;
using OMS.Ice.T4Generator;

namespace MasterThesis.RestTestsGenerator.UnitTestWriters
{
    public class XUnitTestWriter : IUnitTestWriter
    {
        public XUnitTestWriter()
        {
            unitTestsGenerator = new Generator();

            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(UnitTestModel).Assembly.ToString());
            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(Xunit.Assert).Assembly.ToString());
            unitTestsGenerator.Settings.EndOfLine = EndOfLine.CRLF;
        }

        public IEnumerable<Stream> GenerateUnitTest(string intermediateCodePath, string outputFolderPath)
        {
            var outputPath = outputFolderPath == null
                ? Path.GetTempFileName()
                : Path.Combine(outputFolderPath, "test.cs");
            var outputStreams = new List<Stream>();

            //  var inputFile = File.OpenRead(intermediateCodePath);
            // var reader = new XmlTextReader(inputFile);
            var testFile = File.Open(outputPath, FileMode.Create);
            var writer = new StreamWriter(testFile);

            var useCaseObj = GetUnitTestModel(intermediateCodePath);
            unitTestsGenerator.Generate(@"D:\kmatj_000\Documents\Studia\MasterThesis"+
                @"\Soft\MasterThesis\MasterThesis.RestTestsGenerator\UnitTestTemplates\XUnitTestTemplate.tt", writer,useCaseObj);

            return outputStreams;
        }

        private static  IEnumerable<UnitTestModel> GetUnitTestModel(string intemediateFiles)
        {
            IList<UnitTestModel> list = new List<UnitTestModel>();
            
            //TODO: load UnitTestModels from XML
            list.Add(new UnitTestModel
            {
                Method = HttpMethod.Get,
                Body = "::",
                Headers = new Dictionary<string, string>(),
                Link = "google.pl",
                Name = "UnitTestName",
                AssertRestrictionLevel = AssertRestrictionLevel.Headers,
                ResponseCode = HttpStatusCode.OK
            });

            return list;
        }

        private readonly IGenerator unitTestsGenerator;
    }
}