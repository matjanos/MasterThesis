using System.Collections.Generic;
using MasterThesis.RestTestsGenerator.UseCases;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public interface IUseCaseBuilder
    {
        IEnumerable<UseCase> GetUseCases(Resource resource, RamlTypesOrderedDictionary types);
    }
}
