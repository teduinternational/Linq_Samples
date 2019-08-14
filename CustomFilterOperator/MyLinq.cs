using System;
using System.Collections.Generic;
using System.Text;

namespace CustomFilterOperator
{
    public static class MyLinq
    {
        //1. Read only
        //2. Forward only
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,Func<T,bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
                
            }
        }
    }
}
