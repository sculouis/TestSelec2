using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSelect2.Utilites
{
    public static class EnumHelper
    {
        public static List<T> ToList<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList<T>();
        }

        public static IEnumerable<T> ToEnumerable<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }


    }
}
