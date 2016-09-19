using System.Collections.Generic;
using System.Linq;
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
            OutputFile = intermediateFilePath;
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

        public void WriteResourceUseCases(Resource resource, IDictionary<string, string> schema, string currentUri,
            IUseCaseBuilder useCaseBuilder, RamlTypesOrderedDictionary types)
        {
            Log.Debug("Writing data for {0} resource..", resource.DisplayName);

            WriteStartElement("resource");
            if (schema != null)
            {
                WriteSchema(schema[resource.DisplayName]);
            }

            var resourceUri = Url.Combine(currentUri, ReplacePlaceholderWithDefaultParameter(resource));

            WriteAttributeString("name", resource.DisplayName);
            WriteAttributeString("link", resourceUri);

            var useCases = useCaseBuilder.GetUseCases(resource, types);

            foreach (var useCase in useCases)
            {
                PrintUseCase(resourceUri, useCase);
            }

            WriteEndElement();

            foreach (var innerResource in resource.Resources)
            {
                WriteResourceUseCases(innerResource, schema, resourceUri, useCaseBuilder, types);
            }
        }

        private void PrintUseCase(string resourceUri, UseCase useCase)
        {
            WriteStartElement("useCase");
            WriteAttributeString("link", resourceUri);
            WriteAttributeString("method", useCase.Method.GetEnumDescription().ToUpper());
            WriteAttributeString("assert-level", useCase.AssertRestrictionLevel.ToString());
            WriteHeaders(useCase.Headers);

            WriteStartElement("response");
            WriteAttributeString("code", ((int)useCase.ExpectedResponse.Code).ToString());
            WriteString(useCase.ExpectedResponse.Body);
            WriteEndElement();

            WriteEndElement();
        }

        private string ReplacePlaceholderWithDefaultParameter(Resource resource)//TODO: placeholder
        {
            string relativeUri = resource.RelativeUri;


            foreach (var method in resource.Methods)
            {
                if (method.QueryParameters == null)
                    continue;

                foreach (var queryParam in method.QueryParameters)
                {

                    StringBuilder sb = new StringBuilder(queryParam.Key.Length + 2);
                    sb.Append('{');
                    sb.Append($"{queryParam.Key}");
                    sb.Append('}');
                    if (queryParam.Value.Example != null)
                    {
                        if (!relativeUri.Contains("?"))
                            relativeUri += "?";
                        else
                            relativeUri += "&";

                        relativeUri += $"{queryParam.Key}={queryParam.Value.Example.Replace(',','.')}";
                    }
                    else
                    {
                        relativeUri = relativeUri.Replace(sb.ToString(), "xxxxxxx");
                        Log.Warn($"There is no placeholder defined for {queryParam.Key}");
                    }
                }
                }

                // with default parameters
                foreach (var uriParameter in resource.UriParameters)
                {
                    StringBuilder sb = new StringBuilder(uriParameter.Key.Length + 2);
                    sb.Append('{');
                    sb.Append($"{uriParameter.Key}");
                    sb.Append('}');
                    if (uriParameter.Value.Default != null ||
                        (resource.Annotations != null && resource.Annotations.ContainsKey(uriParameter.Key)))
                    {
                        relativeUri = relativeUri.Replace(sb.ToString(), uriParameter.Value.Default ??
                                                                         resource.Annotations?[uriParameter.Key]?.ToString() ??
                                                                         sb.ToString());
                    }
                    else
                    {
                        relativeUri = relativeUri.Replace(sb.ToString(), "xxxxxxx");
                        Log.Warn($"There is no placeholder defined for {uriParameter.Key}");
                    }
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
            Close();
        }

        public string OutputFile { get; private set; }
    }
}