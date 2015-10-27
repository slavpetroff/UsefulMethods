using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTheLongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void PrintTheLongestWord()
        {
            var dictionary = new Dictionary<string, int>();
            string[] inputFirst = Console.ReadLine().Split(' ');
            int max = 0;
            Stack<string> longestWords = new Stack<string>();
            foreach (string word in inputFirst)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 1;
                }
                else
                {
                    dictionary[word]++;
                }
            }

            foreach (var keyValuePair in dictionary)
            {
                int current = keyValuePair.Value;
                if (current > max)
                {
                    longestWords.Push(keyValuePair.Key);
                }
            }

            Console.WriteLine("{0}", longestWords.Peek());
        }
    }
}
