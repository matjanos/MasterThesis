using System.Collections.Generic;
using System.Net;

namespace MasterThesis.RestTestsGenerator.UseCases
{
    public class UseCaseResponse
    {
        public UseCaseResponse(/*TODO: pass model*/HttpStatusCode code, string body)
        {
            Code = code;
            Body = body;
            Headers = new Dictionary<string, string>();

        }

        public HttpStatusCode Code { get; private set; }

        public IDictionary<string, string> Headers { get; set; }

        //TODO: maybe stream?
        public string Body { get; private set; }
    }
}