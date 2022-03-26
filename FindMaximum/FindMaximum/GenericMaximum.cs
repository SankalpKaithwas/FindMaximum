using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    internal class GenericMaximum<T> where T : IComparable
    {
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sortedValues = Sort(values);
            return sortedValues[^1];//this returns the last element after sorting, which is max
        }

      
    }
}
