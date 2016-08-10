using System.Collections.Generic;
using System.Linq;

namespace MasterThesis.Common.Helpers
{
    public static class CollectionHelper
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }
    }
}
