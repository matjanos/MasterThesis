using System.IO;
using System.Net;
using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
using MasterThesis.RestTestsGenerator.UnitTestWriters;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using Xunit;

namespace MasterThesis.RestTestsGenerator.Tests
{
    public class GeneratedTamplate
    {
        [Fact]
        public void GetTest()
        {
            HttpWebRequest httpRequest = WebRequest.CreateHttp("http://xkcd.com/1716/info.0.json");
            httpRequest.Method = "GET";

            var stream = httpRequest.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            var result = reader.ReadToEnd();

            Assert.NotEmpty(result);
        }


        [Fact]
        public void GetTestFromTemplate()
        {
            XUnitTestWriter writer = new XUnitTestWriter();
            writer.GenerateUnitTest("", null);
        }

        [Fact]
        public async void GenerateTest()
        {
            var generator = new RestTestGenerator("TestFiles/Instagram1.0/api.raml");
            var intermediateExpected = "AssertOutFiles/test1.xml";
            var intermediateFilePath = intermediateExpected;//Path.Combine(Path.GetTempPath(), "test1.xml");

            await generator.LoadFile();
            using (var gen = new XmlIntermidiateCodeGenerator(intermediateFilePath))
            {
                var useCaseBuilder = GetUseCaseBuilder();

                generator.GenerateTest(new XUnitTestWriter(), gen, useCaseBuilder);
            }

            var expected = new StreamReader(intermediateExpected);
            var actual = new StreamReader(intermediateFilePath);
            var expectedContent = expected.ReadToEnd();
            var actualContent = actual.ReadToEnd();



            Assert.Equal(expectedContent, actualContent);
        }

        private static CompositeUseCaseBuilder GetUseCaseBuilder()
        {
            var useCaseBuilder = new CompositeUseCaseBuilder();
            useCaseBuilder.AddUseCaseBuilder(new CheckMethodCodeUseCaseBuilder());
            useCaseBuilder.AddUseCaseBuilder(new RequestHeaderCheckUseCaseBuilder());
            useCaseBuilder.AddUseCaseBuilder(new ContentSchemaCheckUseCaseBuilder());
            useCaseBuilder.AddUseCaseBuilder(new ResponseHeaderPatternCheckUseCaseBuilder());
            return useCaseBuilder;
        }
    }
}
