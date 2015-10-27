using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDigitDuplicated
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void PrintDigitDuplicated(string input)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int counter = 0;
            foreach (var i in input)
            {
                if (!dictionary.ContainsKey(i))
                {
                    dictionary[i] = 1;
                }
                else
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
