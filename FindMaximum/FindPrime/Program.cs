using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrime
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void FindPrime(int n, out bool isPrime)
        {
            isPrime = true;
            if (n == 2)
            {
                isPrime = true;
                return;
            }

            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    return;
                }
            }
        }
    }
}
