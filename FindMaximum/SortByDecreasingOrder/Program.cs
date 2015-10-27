using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByDecreasingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void SortByDecreasingOrder(int[] array)
        {
            for (int i1 = 0; i1 < array.Length; i1++)
            {
                int currMin = 0;
                int index = -1;
                int swapper = 0;
                for (int i = i1; i < array.Length; i++)
                {
                    if (array[i] > currMin)
                    {
                        currMin = array[i];
                        index = i;
                    }
                }

                swapper = array[i1];
                array[i1] = currMin;
                array[index] = swapper;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
