namespace LinqExtensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
  
    public static class LinqExtensions
    {
        public static IEnumerable<TResult> WhereNotNull<TIn, TResult>(this IEnumerable<TIn> enumerable, Func<TIn, TResult> selectorFunc)
        {
            return enumerable
                .Select(selectorFunc)
                .Where(value => value != null);
        }
    }
}
