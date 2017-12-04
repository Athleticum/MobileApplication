using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Athleticum.Common.Helpers.Helpers
{
    public static class ReflectionHelpers<T>
    {
        public static T CreateObject(string classType, string assemblyFile)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyFile + ".dll");
            T returnObject = assembly.GetType(classType) != null ? (T) Activator.CreateInstance(assembly.GetType(classType)) : default(T);

            return returnObject;
        }
    }
}
