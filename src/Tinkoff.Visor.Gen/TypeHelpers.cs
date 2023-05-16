using System;
using System.Linq;

namespace Tinkoff.Visor.Gen
{
    public static class TypeHelpers {
        public static bool IsRecordClass(this Type type)
        {
            return type.GetMethods().Any(m => m.Name == "<Clone>$");
        }
    }
}