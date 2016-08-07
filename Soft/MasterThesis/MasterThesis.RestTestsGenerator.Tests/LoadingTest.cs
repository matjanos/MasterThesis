using Xunit;

namespace MasterThesis.RestTestsGenerator.Tests
{
    public class LoadingTest
    {
        [Fact]
        public async void LoadFile()
        {
            var generator = new RestTestGenerator("../../TestFiles/XKCD/api.raml");

            var result = await generator.LoadFile();

            Assert.True(result);
        }

        [Fact]
        public async void LoadBigFile()
        {
            var generator = new RestTestGenerator("../../TestFiles/twitter.raml");

            var result = await generator.LoadFile();

            Assert.True(result);
        }
    }
}
