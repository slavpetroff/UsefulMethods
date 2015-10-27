using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitArrayToSubsV2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void SplitArrayToSubs(
            int[] source,
            int splitInteger,
            out List<int> subArrayOne,
            out List<int> subArrayTwo)
        {
            int[] buffer;
            bool isUsed = false;
            subArrayOne = new List<int>();
            subArrayTwo = new List<int>();
            for (int i = 0; i < source.Length; i += splitInteger)
            {
                if (i + splitInteger <= source.Length)
                {
                    buffer = new int[splitInteger];
                    Array.Copy(source, i, buffer, 0, splitInteger);
                    if (isUsed)
                    {
                        subArrayTwo = buffer.ToList();
                    }
                    else
                    {
                        subArrayOne = buffer.ToList();
                    }

                    isUsed = true;
                }
            }
        }
    }
}
