using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MasterThesis.RestTestsGenerator.UseCases
{
    public class UseCase
    {
        public HttpMethod Method { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Headers { get; set; }

        public UseCaseResponse ExpectedResponse { get; set; }

        public AssertRestrictionLevel AssertRestrictionLevel { get; set; }

        public int Timeout { get; set; }
    }
}