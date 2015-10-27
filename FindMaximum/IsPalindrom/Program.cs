using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void IsPalindrom(string input, out bool isPalindrom)
        {
            isPalindrom = false;
            for (int i = 0, j = input.Length - 1; i < input.Length / 2 && j >= input.Length / 2; i++, j--)
            {
                isPalindrom = input[i] == input[j];
            }
        }
    }
}
