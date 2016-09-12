using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;

namespace Raml.Parser.Builders
{
    public class AnnotationsBuilder
    {
        private const string AnnotationsNodeName = "annotations";

        public static IDictionary<string, object> GetAnnotations(IDictionary<string, object> dynamicRaml)
        {
            if (!dynamicRaml.ContainsKey(AnnotationsNodeName))
                return null;

            var annotations = dynamicRaml[AnnotationsNodeName] as IDictionary<string,object>;

            return annotations?.ToDictionary(p => p.Key, GetAnnotationValue);
        }


        private static object GetAnnotationValue(KeyValuePair<string, object> pair)
        {
            var val = pair.Value as IDictionary<string, object>;

            return val?["structuredValue"];
        }
    }
}