
namespace SplitStringToArrayOfIntegers
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

        }

        private static int[] SplitStringToArrayOfIntegers(string inputString, char delimiter)
        {
            string[] split = inputString.Split(delimiter);
            int[] inputArray = split.Select(int.Parse).ToArray();
            return inputArray;
        }
    }
}
