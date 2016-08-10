using System.Collections.Generic;
using System.Net;
using MasterThesis.RestTestsGenerator.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class HeaderCheckUseCaseBuilder : IUseCaseBuilder
    {
        public IEnumerable<UseCase> GetUseCases(Resource resource)
        {
            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                foreach (var mimeType in method.Body)
                {
                    var uc = new UseCase
                    {
                        AssertRestrictionType = AssertRestrictionType.ResultFormat,
                        Method = method.GetMethodEnum().Value,
                        Headers = new[] {new KeyValuePair<string, string>("Content-Type", mimeType.Key),},
                        ExpectedResponse = new UseCaseResponse(HttpStatusCode.OK, mimeType.Value.Example)
                    };

                    useCases.Add(uc);
                }
            }

            return useCases;
        }
    }
}