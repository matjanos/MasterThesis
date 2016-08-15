using System.Collections.Generic;
using System.Net;
using MasterThesis.RestTestsGenerator.UseCases;

namespace MasterThesis.RestTestsGenerator.UnitTestWriters
{
    public class UnitTestModel
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public HttpMethod Method { set; get; }

        public AssertRestrictionLevel AssertRestrictionLevel { get; set; }

        public HttpStatusCode ResponseCode { get; set; }

        public IDictionary<string,string> Headers { get; set; }

        public string Body { get; set; }
    }
}
