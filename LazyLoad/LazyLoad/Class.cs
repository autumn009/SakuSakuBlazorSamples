using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace LazyLoad
{
    public class Class
    {
        public static string Sub()
        {
            bool b = AppDomain.CurrentDomain.GetAssemblies().Any(c => c.FullName.Contains("ClassLibrary1"));
            int n = AppDomain.CurrentDomain.GetAssemblies().Count();
            return (b ? "Found" : "Not Found") + " checked " + n + "items";
        }
    }
}
