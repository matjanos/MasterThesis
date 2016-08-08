using System.Collections.Generic;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.IntermediateCodeGenerator
{
    public interface IIntermidiateCodeGenerator
    {
        void WriteDocumentStart();

        void WriteResource(Resource resource, IDictionary<string, string> schema, string currentUri);

        void WriteDocumentEnd();
    }
}