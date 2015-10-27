namespace SumOfDigitsOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static int SumOfDigitsOfInteger(int integer)
        {
            int digitSum = 0;
            while (integer > 0)
            {
                digitSum += integer % 10;
                integer /= 10;
            }

            integer = digitSum;
            return integer;
        }
    }
}
