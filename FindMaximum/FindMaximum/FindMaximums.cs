using System;

namespace FindMaximum
{
    public class FindMaximums<T> where T: IComparable
    {
        public T GetMaximum(T firstString, T secondString, T thirdString)
        {
            T max = firstString;
            if (secondString.CompareTo(max) > 0)
            {
                max = secondString;
            }
            if (thirdString.CompareTo(max) > 0)
            {
                max = thirdString;
            }
            return max;
        }
    }
}
