using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using MasterThesis.RestTestsGenerator.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using Newtonsoft.Json.Schema;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class ContentCheckUseCaseBuilder : IUseCaseBuilder
    {
        private ILogger Log = LogManager.GetCurrentClassLogger();

        public IEnumerable<UseCase> GetUseCases(Resource resource, RamlTypesOrderedDictionary types)
        {
            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                foreach (var response in method.Responses)
                {
                    if (response.Body == null || response.Code != "200")
                        continue;

                    foreach (var mimeType in response.Body)
                    {
                        if (mimeType.Value.Example == null)
                            continue;

                        var useCaseResponse = new UseCaseResponse(HttpStatusCode.OK, mimeType.Value.Example);

                        var uc = new UseCase
                        {
                            AssertRestrictionLevel = AssertRestrictionLevel.Structure,
                            Method = method.GetMethodEnum().Value,
                            Headers = new[] { new KeyValuePair<string, string>("Accept", mimeType.Key), },
                            ExpectedResponse = useCaseResponse
                        };

                        useCases.Add(uc);
                    }
                }
            }

            return useCases;
        }
    }
}
