using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLis
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void PrintLis(int[] array)
        {
            List<int> lis = new List<int>();
            var dic = new Dictionary<int, string>();
            int key = 1;

            int max = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int current = array[i];
                int next = array[i + 1];
                if (current < next)
                {
                    lis.Add(current);
                }
                else if (i > 0 && current > array[i - 1])
                {
                    lis.Add(current);
                    dic[key] = string.Join(" ", lis);
                    lis.Clear();
                    key++;
                }

                if (i == array.Length - 2 && current < next)
                {
                    lis.Add(next);
                    dic[key] = string.Join(" ", lis);
                }
            }

            switch (dic.Keys.Count)
            {
                case 1:
                    max = 1;
                    break;
                case 2:
                    max = dic[1].Length > dic[2].Length ? 1 : 2;
                    break;

                default:
                    for (int i = 1; i <= dic.Count - 1; i++)
                    {
                        var currentMax = i;
                        if (dic.ContainsKey(i))
                        {
                            if (dic[i].Length > dic[i + 1].Length)
                            {
                                if (max < currentMax)
                                {
                                    max = currentMax;
                                    currentMax = 0;
                                }
                            }

                            if (i == dic.Count - 1 && dic[i + 1].Length > dic[i].Length)
                            {
                                if (max < currentMax)
                                {
                                    max = currentMax + 1;
                                    currentMax = 0;
                                }
                            }
                        }
                    }

                    break;
            }

            Console.WriteLine(string.Join(",", dic[max]));
        }
    }
}
