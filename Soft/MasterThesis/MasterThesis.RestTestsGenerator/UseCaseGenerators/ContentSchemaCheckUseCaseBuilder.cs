using System.Collections.Generic;
using System.Net;
using MasterThesis.RestTestsGenerator.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class ContentSchemaCheckUseCaseBuilder : IUseCaseBuilder
    {
        private ILogger Log = LogManager.GetCurrentClassLogger();

        public IEnumerable<UseCase> GetUseCases(Resource resource)
        {
            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                foreach (var mimeType in method.Body)
                {
                    foreach (var response in method.Responses)
                    {
                        if(response.Body == null)
                            continue;

                        if (!response.Body.ContainsKey(mimeType.Key))
                        {
                            Log.Error($"There is no definition of response for request Content-Type: {mimeType.Key}");
                            continue;
                        }

                        if (response.Body[mimeType.Key].Schema == null)
                        {
                            Log.Error($"There is no definition of response schema for request Content-Type: {mimeType.Key}");
                            continue;
                        }

                        var useCaseResponse = new UseCaseResponse(HttpStatusCode.OK, mimeType.Value.Schema);

                        var uc = new UseCase
                        {
                            AssertRestrictionLevel = AssertRestrictionLevel.Headers,
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
