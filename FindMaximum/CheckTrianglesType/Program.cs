using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTrianglesType
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void CheckTrianglesType(string input, out bool equilateral, out bool isosceles, out bool scalene)
        {
            string[] str = input.Split(' ');
            int[] array = str.Select(int.Parse).ToArray();
            equilateral = false; // Равностранен
            isosceles = false; // Равнобедрен
            scalene = false; // Разностранен
            int a = array[0];
            int b = array[1];
            int c = array[2];

            if (a == b && b == c && c == a)
            {
                equilateral = true;
            }
            else if (a == b || b == c || a == c)
            {
                isosceles = true;
            }
            else
            {
                scalene = true;
            }
        }
    }
}
