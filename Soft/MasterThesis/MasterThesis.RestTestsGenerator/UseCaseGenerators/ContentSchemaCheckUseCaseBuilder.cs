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
    public class ContentSchemaCheckUseCaseBuilder : IUseCaseBuilder
    {
        private ILogger Log = LogManager.GetCurrentClassLogger();

        public IEnumerable<UseCase> GetUseCases(Resource resource, RamlTypesOrderedDictionary types)
        {
            var useCases = new List<UseCase>();

            foreach (var method in resource.Methods)
            {
                foreach (var response in method.Responses)
                {
                    if (response.Body == null)
                        continue;

                    foreach (var mimeType in response.Body)
                    {
                        if (mimeType.Value.Type == null || !types.ContainsKey(mimeType.Value.Type))
                            continue;

                        var type = types[mimeType.Value.Type];

                        var useCaseResponse = new UseCaseResponse(HttpStatusCode.OK, GetTypeStructure(type, types).ToString());

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

        private JSchema GetTypeStructure(RamlType ramlType, RamlTypesOrderedDictionary types)
        {
            var schema = new JSchema();

            schema.Type = GetSchemaTypeEnum(ramlType.Type);

            if (ramlType.Object?.Properties == null)
                return schema;


            if (types.ContainsKey(ramlType.Type))
            {

                foreach (var type in (types[ramlType.Type] as dynamic).Object.Properties)
                {
                    schema.Properties.Add(type.Key, GetTypeStructure(type.Value as RamlType, types));

                }
            }
            foreach (var property in ramlType.Object.Properties)
            {
                if (property.Value.Required)
                    schema.Required.Add(property.Value.Name);

                schema.Properties.Add(property.Key, GetTypeStructure(property.Value, types));
            }

            return schema;
        }

        private JSchemaType GetSchemaTypeEnum(string type)
        {
            if (string.IsNullOrEmpty(type))
                return JSchemaType.None;

            var upperCaseType = $"{char.ToUpper(type[0])}{type.Substring(1)}";

            JSchemaType t;
            if (Enum.TryParse(upperCaseType, out t))
                return t;

            if (upperCaseType.EndsWith("[]"))
                return JSchemaType.Array;
            if (type.Contains("null"))
                return JSchemaType.Null | JSchemaType.Object;

            return JSchemaType.Object;
        }
    }
}
