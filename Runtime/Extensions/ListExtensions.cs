using System;
using System.Collections.Generic;

namespace DomesUnityToolkit.Extensions
{
    public static class ListExtensions
    {
        // make this callable on a list with list.Concatenate(x => x.friendlyName, ', ')
        public static string Concatenate<T>(this List<T> list, Converter<T, string> convert, string separator)
        {
            return string.Join(separator, list.ConvertAll(convert));
        }
    }
}