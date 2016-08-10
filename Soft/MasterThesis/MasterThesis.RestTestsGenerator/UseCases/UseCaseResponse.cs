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

        public bool AssertEquality(UseCaseResponse useCaseResponse)
        {
            if (Code != useCaseResponse.Code)
                return false;

            //TODO: if all required fields are present and equal and other fields are equal if exist (or strategies)
            return true;
        }
    }
}