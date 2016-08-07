using System.IO;
using System.Net;
using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
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
        public async void GenerateTest()
        {
            var generator = new RestTestGenerator("../../TestFiles/test.raml");
            var intermediateExpected = "../../AssertOutFiles/test1.xml";
            var intermediateFilePath = intermediateExpected;//Path.Combine(Path.GetTempPath(), "test1.xml");

            await generator.LoadFile();
            using (var gen = new XmlIntermidiateCodeGenerator(intermediateFilePath))
            {
                generator.GenerateTest(new XUnitTestWriter(), gen);
            }

            var expected = new StreamReader(intermediateExpected);
            var actual = new StreamReader(intermediateFilePath);
            Assert.Equal(expected.ReadToEnd(), actual.ReadToEnd());
        }


    }
}
