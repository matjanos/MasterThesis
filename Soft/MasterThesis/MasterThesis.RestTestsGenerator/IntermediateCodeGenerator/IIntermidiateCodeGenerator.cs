using System;
using System.Collections.Generic;
using MasterThesis.RestTestsGenerator.Assertions;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.IntermediateCodeGenerator
{
    public interface IIntermidiateCodeGenerator
    {
        void WriteDocumentStart();

        void WriteMethodRequest(HttpMethod method, string url, AssertionConditions condition);

        void WriteResource(Resource resource, IDictionary<string, string> schema, string currentUri);

        void WriteDocumentEnd();
    }
}