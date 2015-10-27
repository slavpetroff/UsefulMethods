using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEqualNumbersSequence
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void CheckEqualNumbersSequence(string str, out int max, out int number)
        {
            string[] input = str.Split(' ');
            int[] array = input.Select(int.Parse).ToArray();
            int prev = array[0];
            int counter = 1;
            number = 0;
            max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == prev)
                {
                    number = array[i];
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (max < counter)
                {
                    max = counter;
                }

                prev = array[i];
            }
        }
    }
}
