using System;

namespace FindMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 34;
            int numberTwo = 123;
            int numberThree = 19;

            int maximum = GetMaximum(numberOne, numberTwo, numberThree);
            Console.WriteLine(maximum);

        }
        private static int GetMaximum(int numberOne, int numberTwo, int numberThree)
        {
            int max = numberOne;
            if (numberTwo.CompareTo(max) > 0)
            {
                max = numberTwo;
            }
            if (numberThree.CompareTo(max) > 0)
            {
                max = numberThree;
            }
            return max;
        }
    }
}
