using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitArrayToSubs
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void SplitArrayToSubs(int[] source, int splitInteger)
        {
            int[] buffer;

            for (int i = 0; i < source.Length; i += splitInteger)
            {
                if (i + splitInteger < source.Length)
                {
                    buffer = new int[splitInteger];
                    Array.Copy(source, i, buffer, 0, splitInteger);
                }
            }
        }

    }
}
