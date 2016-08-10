using System.Collections.Generic;

namespace MasterThesis.RestTestsGenerator.UseCases
{
    public class UseCase
    {
        public HttpMethod Method { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public UseCaseResponse ExpectedResponse { get; set; }

        public AssertRestrictionType AssertRestrictionType { get; set; }
    }
}