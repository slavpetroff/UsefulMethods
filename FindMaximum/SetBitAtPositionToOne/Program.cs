using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetBitAtPositionToOne
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void SetBitAtPositionToOne(int number, int position, out int result)
        {
            int mask = 1 << position;
            result = number | mask;
        }

    }
}
