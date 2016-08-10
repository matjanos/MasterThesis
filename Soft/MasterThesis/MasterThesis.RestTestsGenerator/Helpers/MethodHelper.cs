using MasterThesis.Common.Helpers;
using Raml.Parser.Expressions;

namespace MasterThesis.RestTestsGenerator.Helpers
{
    public static class MethodHelper
    {
        public static HttpMethod? GetMethodEnum(this Method method)
        {
            HttpMethod m;

            if (!EnumHelper.TryGetEnumValueFromDescription(method.Verb.ToUpper(), out m))
                return null;

            return m;
        }
    }
}
