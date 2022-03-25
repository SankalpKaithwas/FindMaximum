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
            //UC1 Find maximum integer
            int maximum = FindMaximum.GetMaximum(numberOne, numberTwo, numberThree);
            Console.WriteLine($"Maximum among [{numberOne}, {numberTwo}, " +
                $"{numberThree}] is: {maximum}");

            // UC2 find Maximum Float
            double maximumDouble = FindMaximum.GetMaximumFloat(12.3, 23.4, 20);
            Console.WriteLine($"Maximum among [12.3, 23.4, 20] is: {maximumDouble}");

            // UC3 find maximum string
            string maxString = FindMaximum.GetMaximumString("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum among [Apple, Peach, banana] is: " + maxString);

        }

    }
}
