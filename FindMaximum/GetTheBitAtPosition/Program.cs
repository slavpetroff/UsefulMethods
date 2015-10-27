using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheBitAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void GetTheBitAtPosition(int number, int position, out int bit)
        {
            int numberRight = number >> position;
            bit = numberRight & 1;
        }
    }
}
