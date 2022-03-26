using System;


namespace FindMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMaximums<int> maxInt = new FindMaximums<int>();
            int maximum = maxInt.GetMaximum(12, 34, 56);
            Console.WriteLine($"Maximum is: {maximum}");
            FindMaximums<double> maxDouble = new FindMaximums<double>();
            double maximumDouble = maxDouble.GetMaximum(12.3, 23.4, 20);
            Console.WriteLine($"Maximum is: {maximumDouble}");
            FindMaximums<string> maxString = new FindMaximums<string>();
            string maximumString = maxString.GetMaximum("Apple", "Peach", "Banana");
            Console.WriteLine($"Maximum is: {maximumString}");

            //UC4 take more than Three parameters
            int[] array = { 1, 2, 300, 4, 5, 45, 100 };
            string[] words = { "Apple", "Peach", "Banana", "Sankalp", "Kaithwas" };

            GenericMaximum<int> maxInts = new GenericMaximum<int>();
            Console.WriteLine("Maximum value is " + maxInts.MaxValue(array));
            GenericMaximum<string> maxStrings = new GenericMaximum<string>();
            Console.WriteLine("Maximum value is " + maxStrings.MaxValue(words));

        }
    }
}
