using System.Collections.Generic;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.IntermediateCodeGenerator
{
    public interface IIntermidiateCodeGenerator
    {
        void WriteDocumentStart();

        void WriteResourceUseCases(Resource resource, IDictionary<string, string> schema, string currentUri, IUseCaseGenerator useCaseGenerator);

        void WriteDocumentEnd();
    }
}