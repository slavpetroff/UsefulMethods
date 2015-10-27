using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMAndGCD
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void LCMAndGCD(int n, int m, out int GCD, out int LCM)
        {
            GCD = 0;
            LCM = 0;

            for (int i = 2; i < 100; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    int current = i;
                    if (i > GCD)
                    {
                        GCD = i;
                    }
                }
            }

            LCM = (m * n) / GCD;
        }
    }
}
