using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CS.Service.WebHost
{
    public static class AssemblyScanner
    {
        private static readonly string CommonAssembyPrefix = "CS.Service";

        public static IEnumerable<Assembly> GetServiceAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => assembly.FullName.StartsWith(CommonAssembyPrefix)).ToList();
        }
    }
}