using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using MasterThesis.RestTestsGenerator.UseCases;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLog.Fluent;
using OMS.Ice.T4Generator;

namespace MasterThesis.RestTestsGenerator.UnitTestWriters
{
    public class XUnitTestWriter : IUnitTestWriter
    {
        public XUnitTestWriter()
        {
            unitTestsGenerator = new Generator();

            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(UnitTestModel).Assembly.ToString());
            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(Xunit.Assert).Assembly.ToString());
            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(IEnumerable<>).Assembly.ToString());
            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(JSchema).Assembly.ToString());
            unitTestsGenerator.Settings.ReferenceAssemblies.Add(typeof(JObject).Assembly.ToString());
            unitTestsGenerator.Settings.EndOfLine = EndOfLine.CRLF;
        }

        public IEnumerable<Stream> GenerateUnitTest(string intermediateCodePath, string outputFolderPath)
        {
            var outputPath = outputFolderPath == null
                ? Path.GetTempFileName()
                : Path.Combine(outputFolderPath, "test.cs");
            var outputStreams = new List<Stream>();

            //  var inputFile = File.OpenRead(intermediateCodePath);
            // var reader = new XmlTextReader(inputFile);
            var testFile = File.Open(outputPath, FileMode.Create);
            var writer = new StreamWriter(testFile);

            var useCaseObj = GetUnitTestModel(intermediateCodePath);

            var templateFile = @"D:\kmatj_000\Documents\Studia\MasterThesis" +
                               @"\Soft\MasterThesis\MasterThesis.RestTestsGenerator\UnitTestTemplates\XUnitTestTemplate.tt";

            if (!File.Exists(templateFile))
                throw new FileNotFoundException("Nie znaleziono szablonu");

            unitTestsGenerator.Generate(templateFile, writer, useCaseObj);

            writer.Close();

            return outputStreams;
        }

        private static IEnumerable<UnitTestModel> GetUnitTestModel(string intemediateFile)
        {
            IList<UnitTestModel> list = new List<UnitTestModel>();

            XmlTextReader reader = new XmlTextReader(File.Open(intemediateFile, FileMode.Open));

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "useCase")
                {
                    HttpMethod method;
                    Enum.TryParse(reader.GetAttribute("method"), out method);


                    AssertRestrictionLevel assertionLevel;
                    Enum.TryParse(reader.GetAttribute("assert-level"), out assertionLevel);

                    string url = reader.GetAttribute("link");
                    HttpStatusCode responseCode = HttpStatusCode.OK;
                    var useCaseReader = reader.ReadSubtree();
                    var headers = new Dictionary<string, string>();

                    string body = null;
                    while (useCaseReader.Read())
                    {
                        if (useCaseReader.Name == "response")
                        {
                            if (!useCaseReader.IsStartElement())
                                continue;

                            Enum.TryParse(useCaseReader.GetAttribute("code"), out responseCode);


                            useCaseReader.Read();
                            if (useCaseReader.NodeType == XmlNodeType.Text)
                                body = useCaseReader.Value;
                        }
                        if (useCaseReader.Name == "header" && useCaseReader.GetAttribute("key") != null)
                        {
                            headers.Add(useCaseReader.GetAttribute("key"), useCaseReader.GetAttribute("value"));
                        }
                    }
                    list.Add(new UnitTestModel
                    {
                        Method = method,
                        Body = body?.Replace("\"", "\"\""),
                        Headers = headers,
                        Link = url,
                        Name = $"Test_{Guid.NewGuid().ToString().Replace("-", "")}",
                        AssertRestrictionLevel = assertionLevel,
                        ResponseCode = responseCode
                    });
                }
            }



            return list;
        }

        private readonly IGenerator unitTestsGenerator;
    }
}