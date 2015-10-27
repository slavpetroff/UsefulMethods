using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static long SumOfDigits(string str, char delimiter)
        {
            string[] input = str.Split(delimiter);
            string converted = string.Join(string.Empty, input);
            long integer = long.Parse(converted);
            long sum = 0;
            long digitSum = 0;
            while (integer > 0)
            {
                digitSum += integer % 10;
                integer /= 10;
            }

            sum = digitSum;
            return sum;
        }
    }
}
