using System.Collections.Generic;
using System.Text;
using System.Xml;
using Flurl;
using MasterThesis.Common.Helpers;
using MasterThesis.RestTestsGenerator.UseCaseGenerators;
using MasterThesis.RestTestsGenerator.UseCases;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.IntermediateCodeGenerator
{
    public class XmlIntermidiateCodeGenerator : XmlTextWriter, IIntermidiateCodeGenerator
    {
        private readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public XmlIntermidiateCodeGenerator(string intermediateFilePath) : base(intermediateFilePath, Encoding.UTF8)
        {
            Formatting = Formatting.Indented;
            IndentChar = '\t';
            Indentation = 1;
        }

        public void WriteDocumentStart()
        {
            WriteStartDocument(true);
            WriteStartElement("testDefinition");
        }

        private void WriteSchema(string schema)
        {
            WriteStartElement("schema");

            WriteRaw(schema);

            WriteEndElement();
        }

        public void WriteResourceUseCases(Resource resource, IDictionary<string, string> schema, string currentUri, IUseCaseGenerator useCaseGenerator)
        {
            Log.Info("Writing data for {0} resource..", resource.DisplayName);

            WriteStartElement("resource");
            if (schema != null)
            {
                WriteSchema(schema[resource.DisplayName]);
            }

            var resourceUri = Url.Combine(currentUri, ReplacePlaceholderWithDefaultParameter(resource));

            WriteAttributeString("name", resource.DisplayName);
            WriteAttributeString("link", resourceUri);


            var useCases = useCaseGenerator.GetUseCases(resource);
            foreach (var useCase in useCases)
            {
                PrintUseCase(resourceUri, useCase);
            }

            WriteEndElement();

            foreach (var innerResource in resource.Resources)
            {
                WriteResourceUseCases(innerResource, schema, resourceUri, useCaseGenerator);
            }
        }

        private void PrintUseCase(string resourceUri, UseCase useCase)
        {
            WriteStartElement("useCase");
            WriteAttributeString("link", resourceUri);
            WriteAttributeString("method", useCase.Method.GetEnumDescription().ToUpper());
            WriteAttributeString("assert", useCase.AssertRestrictionType.ToString());
            WriteHeaders(useCase.Headers);

            WriteStartElement("response");
            WriteAttributeString("code", ((int)useCase.ExpectedResponse.Code).ToString());
            WriteString(useCase.ExpectedResponse.Body);
            WriteEndElement();

            WriteEndElement();
        }

        private static string ReplacePlaceholderWithDefaultParameter(Resource resource)
        {
            string relativeUri = resource.RelativeUri;
            foreach (var uriParameter in resource.UriParameters)
            {
                StringBuilder sb = new StringBuilder(uriParameter.Key.Length + 2);
                sb.Append('{');
                sb.Append($"{uriParameter.Key}");
                sb.Append('}');
                relativeUri = relativeUri.Replace(sb.ToString(), uriParameter.Value.Default ?? "0");
            }

            return relativeUri;
        }

        private void WriteHeaders(IEnumerable<KeyValuePair<string, string>> headers)
        {
            foreach (var header in headers)
            {
                WriteStartElement("header");
                WriteAttributeString("key", header.Key);
                WriteAttributeString("value", header.Value);
                WriteEndElement();
            }
        }

        public void WriteDocumentEnd()
        {
            WriteEndElement();
            WriteEndDocument();
        }
    }
}