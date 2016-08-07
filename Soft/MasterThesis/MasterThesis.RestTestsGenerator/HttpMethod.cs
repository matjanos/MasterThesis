using System.ComponentModel;

namespace MasterThesis.RestTestsGenerator
{
    public enum HttpMethod
    {
        [Description("GET")]
        Get = 0,

        [Description("PUT")]
        Put = 1,

        [Description("POST")]
        Post = 2,

        [Description("DELETE")]
        Delete = 3,

        [Description("Patch")]
        Patch = 4,
    }
}
