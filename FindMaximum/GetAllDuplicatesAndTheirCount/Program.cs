using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllDuplicatesAndTheirCount
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static Dictionary<int, int> GetAllDuplicatesAndTheirCount(int[] array)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (int dup in array)
            {
                if (!dictionary.ContainsKey(dup))
                {
                    dictionary[dup] = 1;
                }
                else
                {
                    dictionary[dup]++;
                }
            }

            return dictionary;
        }
    }
}
