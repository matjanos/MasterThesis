using System.Collections.Generic;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.IntermediateCodeGenerator
{
    public interface IIntermidiateCodeGenerator
    {
        void WriteDocumentStart();

        void WriteResourceUseCases(Resource resource, IDictionary<string, string> schema, string currentUri,
            IUseCaseBuilder useCaseBuilder, RamlTypesOrderedDictionary types);

        void WriteDocumentEnd();

        string OutputFile { get; }
    }
}