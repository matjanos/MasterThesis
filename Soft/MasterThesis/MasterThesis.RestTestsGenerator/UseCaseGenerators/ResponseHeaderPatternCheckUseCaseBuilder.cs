using System.Collections.Generic;
using System.Linq;
using System.Net;
using MasterThesis.RestTestsGenerator.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class ResponseHeaderPatternCheckUseCaseBuilder : IUseCaseBuilder
    {
        public IEnumerable<UseCase> GetUseCases(Resource resource)
        {
            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                foreach (var mimeType in method.Body)
                {
                    var useCaseResponse = new UseCaseResponse(HttpStatusCode.OK, mimeType.Value.Example);
                    foreach (var response in method.Responses)
                    {
                        useCaseResponse.Headers = response.Headers.ToDictionary(h => h.Key, v=>v.Value.Pattern);
                    }

                    var uc = new UseCase
                    {
                        AssertRestrictionLevel = AssertRestrictionLevel.Headers,
                        Method = method.GetMethodEnum().Value,
                        Headers = new[] { new KeyValuePair<string, string>("Content-Type", mimeType.Key), },
                        ExpectedResponse = useCaseResponse
                    };

                    useCases.Add(uc);
                }
            }

            return useCases;
        }
    }
}