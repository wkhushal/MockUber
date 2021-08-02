using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach(var item in sequence)
            {
                action(item);
            }
        }
    }
}
