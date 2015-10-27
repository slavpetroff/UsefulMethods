using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumDividers
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void NumDividers(int p, out Dictionary<int, int> dictionary)
        {
            int i = 2;
            int k = 0;
            dictionary = new Dictionary<int, int>();
            while (p != 1)
            {
                if (p % i == 0)
                {
                    while (p % i == 0)
                    {
                        p /= i;
                        k++;
                    }

                    if (!dictionary.ContainsKey(i))
                    {
                        dictionary[i] = k;
                    }

                    k = 0;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
