using System.Collections.Generic;
using System.Text;
using System.Xml;
using Flurl;
using MasterThesis.Common.Helpers;
using NLog;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.IntermediateCodeGenerator
{
    public class XmlIntermidiateCodeGenerator : XmlTextWriter, IIntermidiateCodeGenerator
    {
        private readonly ILogger Log = LogManager.GetCurrentClassLogger();
        private const int TimeOut = 200;

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

        public void WriteResource(Resource resource, IDictionary<string, string> schema, string currentUri)
        {
            WriteStartElement("resource");
            if (schema != null)
            {
                WriteSchema(schema[resource.DisplayName]);
            }

            var resourceUri = Url.Combine(currentUri, ReplacePlaceholderWithDefaultParameter(resource));

            WriteAttributeString("name", resource.DisplayName);
            WriteAttributeString("link", resourceUri);
            WriteMethods(resource);
            WriteEndElement();

            foreach (var innerResource in resource.Resources)
            {
                WriteResource(innerResource, schema, resourceUri);
            }
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

        private void WriteMethods(Resource resource)
        {



            foreach (var method in resource.Methods)
            {
                HttpMethod currentMethod;

                if (!EnumHelper.TryGetEnumValueFromDescription(method.Verb.ToUpper(), out currentMethod))
                {
                    Log.Warn($"Unknown method {method.Verb} for {resource.DisplayName} resource. Skipping...");
                    continue;
                }

                WriteStartElement("method");
                WriteAttributeString("value", method.Verb);
                WriteAttributeString("timeout", TimeOut.ToString());
                WriteCase(method);
                WriteEndElement();

                Log.Info($"Creating for {method.Verb}: {method.Description}");
            }
        }

        private void WriteCase(Method method)
        {
            WriteStartElement("case");

            foreach (var response in method.Responses)
            {
                foreach (var responseBody in response.Body)
                {

                    WriteHeaders(method, responseBody);

                    WriteStartElement("result");

                    WriteAttributeString("code", response.Code);
                    WriteString(responseBody.Value.Example);

                    WriteEndElement();
                }
            }

            WriteEndElement();
        }

        private void WriteHeaders(Method method, KeyValuePair<string, MimeType> response)
        {
            WriteStartElement("header");
            WriteAttributeString("key", "Content-Type");
            WriteAttributeString("value", response.Key);
            WriteEndElement();

            foreach (var parameter in method.Headers)
            {
                WriteStartElement("header");
                WriteAttributeString("key", parameter.Key);
                WriteAttributeString("value", response.Value.Example);
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