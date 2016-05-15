using Xunit;

namespace MasterThesis.RestTestsGenerator.Tests
{
    public class ExampleTests
	{
		[Fact]
		public void TestOne()
		{
			var c = new Class();
			var res = c.Add(1, 2);
			Assert.Equal(3, res);
		}
	}
}
