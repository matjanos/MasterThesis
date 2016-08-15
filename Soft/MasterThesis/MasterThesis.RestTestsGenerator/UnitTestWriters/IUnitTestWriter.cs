using System.Collections.Generic;
using System.IO;

namespace MasterThesis.RestTestsGenerator.UnitTestWriters
{
    public interface IUnitTestWriter
    {
        IEnumerable<Stream> GenerateUnitTest(string intermediateCodePath, string outputFolderPath);
    }
}