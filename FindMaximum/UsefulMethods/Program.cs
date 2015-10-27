
namespace UsefulMethods
{
    class Program
    {
        static void Main()
        {

        }
        private static int ConvertingArrayToSingleInteger(int[] array)
        {
            int result = 0;
            int multipicator = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] * multipicator;
                multipicator *= 10;
            }

            return result;
        }
    }
}
