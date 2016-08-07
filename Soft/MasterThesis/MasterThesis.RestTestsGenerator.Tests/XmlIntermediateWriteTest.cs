using MasterThesis.RestTestsGenerator.IntermediateCodeGenerator;
using Xunit;

namespace MasterThesis.RestTestsGenerator.Tests
{
    public class XmlIntermediateWriteTest
    {
        [Fact]
        public void WriteResource()
        {
            using (var writer = new XmlIntermidiateCodeGenerator("./test.xml"))
            {
                writer.WriteDocumentStart();
                //writer.WriteResource("files");
                writer.WriteDocumentEnd();
            }
        }
    }
}
