using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIncreasingNumbersSequence
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void CheckIncreasingNumbersSequence(string str, out bool isIncreasing)
        {
            isIncreasing = false;
            string[] input = str.Split(' ');
            int[] array = input.Select(int.Parse).ToArray();
            int prev = array[0];
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > prev)
                {
                    counter++;
                }

                prev = array[i];
            }

            if (counter == array.Length - 1)
            {
                isIncreasing = true;
            }
        }
    }
}
