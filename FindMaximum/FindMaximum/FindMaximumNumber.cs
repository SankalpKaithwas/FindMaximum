namespace FindMaximum
{
    public class FindMaximumNumber
    {
        public static int GetMaximum(int numberOne, int numberTwo, int numberThree)
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
        public static double GetMaximumFloat(double numberOne, double numberTwo, double numberThree)
        {
            double max = numberOne;
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
