using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void BubbleSort(int[] array)
        {
            for (int i1 = 0; i1 < array.Length; i1++)
            {
                int flag = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var swapper = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swapper;
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
