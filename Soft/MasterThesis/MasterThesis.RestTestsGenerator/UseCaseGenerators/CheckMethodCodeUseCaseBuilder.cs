using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using MasterThesis.RestTestsGenerator.UseCases;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class CheckMethodCodeUseCaseBuilder : IUseCaseBuilder
    {
        public readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public IEnumerable<UseCase> GetUseCases(Resource resource, RamlTypesOrderedDictionary types)
        {
            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                HttpMethod methodType;
                if(!HttpMethod.TryParse(method.Verb, true, out methodType))
                    continue;
                foreach (var response in method.Responses)
                {
                    HttpStatusCode code;
                    if(!Enum.TryParse(response.Code, out code))
                        continue;
                    try
                    {
                        useCases.Add(new UseCase
                        {
                            Method = methodType,
                            Headers =
                                method.Headers.Select(
                                    pair => new KeyValuePair<string, string>(pair.Key, pair.Value.Example)),
                            AssertRestrictionLevel = AssertRestrictionLevel.StatusCode,
                            ExpectedResponse = new UseCaseResponse(code, String.Empty),
                            Timeout = 5000
                        });
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex);
                    }
                }
            }

            return useCases;
        }
    }
}