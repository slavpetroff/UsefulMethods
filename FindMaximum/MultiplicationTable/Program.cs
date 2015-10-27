using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void MultiplicationTable(long rows, long columns, long startingRows, long startingColumns)
        {
            long startColumns = startingColumns;
            long startRows = startingRows;
            long nextRow = startRows + 1;

            for (long i = 0; i < rows; i++)
            {
                for (long j = 1; j <= columns; j++)
                {
                    long currentNumber = 1;
                    if (j == columns)
                    {
                        currentNumber = startRows * startColumns;
                        Console.Write(currentNumber);
                        Console.Write("\n");
                        startColumns = startingColumns;
                        startRows = nextRow;
                        nextRow++;
                        break;
                    }

                    currentNumber = startRows * startColumns;
                    Console.Write(currentNumber + " ");
                    startColumns++;
                }
            }
        }
    }
}
