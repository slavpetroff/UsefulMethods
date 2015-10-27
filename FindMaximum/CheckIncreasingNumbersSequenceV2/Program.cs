using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIncreasingNumbersSequenceV2
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void CheckIncreasingNumbersSequence(
           int[] array,
           out bool wholeArrayIncreasing,
           out List<int> list)
        {
            list = new List<int>();
            wholeArrayIncreasing = false;
            int next = 1;
            int counter = 0;
            var isIncreasing = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[next])
                {
                    counter++;
                    isIncreasing = true;
                    list.Add(array[i]);
                }
                else if (array[i] > array[next] && isIncreasing)
                {
                    list.Add(array[i]);
                    isIncreasing = false;
                }
                else
                {
                    counter = 0;
                    isIncreasing = false;
                }

                next++;
            }

            wholeArrayIncreasing = counter == array.Length - 1;
        }
    }
}
