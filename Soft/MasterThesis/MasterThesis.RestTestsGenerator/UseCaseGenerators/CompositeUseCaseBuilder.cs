using System.Collections.Generic;
using MasterThesis.Common.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class CompositeUseCaseBuilder : IUseCaseBuilder
    {
        public CompositeUseCaseBuilder()
        {
            useCaseGenerators = new List<IUseCaseBuilder>();
        }

        private readonly ICollection<IUseCaseBuilder> useCaseGenerators;

        public IEnumerable<UseCase> GetUseCases(Resource resource, RamlTypesOrderedDictionary types)
        {
            var useCases = new List<UseCase>();

            foreach (var useCaseGenerator in useCaseGenerators)
            {
                var ucs = useCaseGenerator.GetUseCases(resource, types);
                if (ucs.IsNullOrEmpty())
                    continue;

                useCases.AddRange(ucs);
            }

            return useCases;
        }

        public void AddUseCaseBuilder(IUseCaseBuilder useCaseBuilder)
        {
            useCaseGenerators.Add(useCaseBuilder);
        }
    }
}