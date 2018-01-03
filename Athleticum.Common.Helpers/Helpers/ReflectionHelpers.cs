using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Athleticum.Common.Helpers.Helpers
{
    public static class ReflectionHelpers<T>
    {
        public static T CreateObject(string typeName, string dllName)
        {
            Type classType = Type.GetType(typeName + ", " + dllName);

            T returnObject = classType != null ? (T) Activator.CreateInstance(classType) : default(T);

            return returnObject;
        }
    }
}
