using System;
using System.Collections.Generic;
using System.Net;
using MasterThesis.RestTestsGenerator.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class CheckMethodCodeUseCaseBuilder : IUseCaseBuilder
    {
        public readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public IEnumerable<UseCase> GetUseCases(Resource resource)
        {
            /* IList<UseCase> useCases = new List<UseCase>();

             foreach (var method in resource.Methods)
             {
                 var uc = ConstructUseCase(resource, method);
                 if (uc != null)
                     useCases.Add(uc);
             }

             return useCases;*/

            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                foreach (var mimeType in method.Body)
                {
                    foreach (var response in method.Responses)
                    {
                        if (response.Code == null)
                            continue;

                        var useCaseResponse = new UseCaseResponse((HttpStatusCode) Convert.ToInt32(response.Code),null);

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