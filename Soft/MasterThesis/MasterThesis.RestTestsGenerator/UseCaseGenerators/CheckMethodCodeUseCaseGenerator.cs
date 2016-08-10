using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using MasterThesis.Common.Helpers;
using MasterThesis.RestTestsGenerator.UseCases;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.UseCaseGenerators
{
    public class CheckMethodCodeUseCaseGenerator : IUseCaseGenerator
    {
        public readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public IEnumerable<UseCase> GetUseCases(Resource resource)
        {
            IList<UseCase> useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                var uc = ConstructUseCase(resource, method);
                if (uc != null)
                    useCases.Add(uc);
            }

            return useCases;
        }

        private UseCase ConstructUseCase(Resource resource, Method method)
        {
            HttpMethod currentMethod;

            if (!EnumHelper.TryGetEnumValueFromDescription(method.Verb.ToUpper(), out currentMethod))
            {
                Log.Warn($"Unknown method {method.Verb} for {resource.DisplayName} resource. Skipping...");
                return null;
            }

            var responseToAssert = method.Responses.FirstOrDefault();
            if (responseToAssert == null)
            {
                responseToAssert = new Response {Code = "200"};
            }

            var uc = new UseCase
            {
                Method = currentMethod,
                Headers = method.Headers.Select(x => new KeyValuePair<string, string>(x.Key, x.Value.Default)),
                AssertRestrictionType = AssertRestrictionType.StatusCode,
                ExpectedResponse = new UseCaseResponse((HttpStatusCode)Convert.ToInt32(responseToAssert.Code), string.Empty)
            };
            return uc;
        }
    }
}