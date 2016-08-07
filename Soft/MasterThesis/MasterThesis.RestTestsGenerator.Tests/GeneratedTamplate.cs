using System.IO;
using System.Net;
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
            var generator = new RestTestGenerator("../../TestFiles/XKCD/api.raml");

            var result = await generator.LoadFile();
            generator.GenerateTest(new XUnitTestWriter());

            Assert.True(result);
        }
    }
}
