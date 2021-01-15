using System.Collections.Generic;
using System.Linq;

namespace CSharpDemos
{
    public static class DemoExtensionMethods
    {
        public static IEnumerable<int> GetOrderedFirstTenIntegers(this IEnumerable<int> ts)
        {
            var result = ts.OrderBy(x => x).Take(10);
            return result.ToList();
        }
    }
}
