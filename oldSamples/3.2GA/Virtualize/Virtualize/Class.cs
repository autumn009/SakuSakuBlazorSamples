using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtualize
{
    public static class Class
    {
        public static IEnumerable<char> HugeList = sub();
        private static int counter = 0;

        private static IEnumerable<char> sub()
        {
            for (int i = 32; i < 32767; i++)
            {
                if( i == 256)
                    yield return counter.ToString()[0];

                yield return (char)i;
            }
        }
        public static void IncrementCount()
        {
            counter++;
        }
    }
}
