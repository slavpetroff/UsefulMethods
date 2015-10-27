using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBiggestPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void GetBiggestPlatform(int[] arr)
        {
            int maxIndex = 0;
            int maxLenght = 0;
            int tempIndex = 0;
            int tempLeght = 1;

            bool hasPlatforms = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    hasPlatforms = false;
                }
                else
                {
                    hasPlatforms = true;
                }
            }

            if (hasPlatforms == false)
            {
                Console.WriteLine("No platforms !");
            }
            else
            {
                if (arr.Length > 2)
                {
                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (arr[i] == arr[i - 1])
                        {
                            tempIndex = i;
                            tempLeght++;
                        }
                        else if (tempLeght > maxLenght)
                        {
                            maxLenght = tempLeght;
                            maxIndex = tempIndex;
                            tempIndex = i + 1;
                            tempLeght = 1;
                        }
                    }

                    if (tempLeght > maxLenght)
                    {
                        maxLenght = tempLeght;
                        maxIndex = tempIndex;
                    }

                    int[] newArr = new int[tempLeght];
                    for (int j = 0, i = tempIndex - (tempLeght - 1); i <= tempIndex; i++, j++)
                    {
                        newArr[j] = arr[i];
                    }

                    Console.WriteLine(string.Join(" ", newArr));
                }
                else if (arr.Length == 2)
                {
                    if (arr[0] > arr[1])
                    {
                        Console.WriteLine(arr[0]);
                    }
                    else
                    {
                        Console.WriteLine(arr[1]);
                    }
                }
                else
                {
                    Console.WriteLine(arr[0]);
                }
            }
        }
    }
}
