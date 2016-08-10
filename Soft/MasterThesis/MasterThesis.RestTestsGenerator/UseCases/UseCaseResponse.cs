using System.Net;

namespace MasterThesis.RestTestsGenerator.UseCases
{
    public class UseCaseResponse
    {
        public UseCaseResponse(/*TODO: pass model*/HttpStatusCode code, string body)
        {
            Code = code;
            Body = body;
        }

        public HttpStatusCode Code { get; private set; }

        //TODO: maybe stream?
        public string Body { get; private set; }
    }
}