using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 1, 2, 3, 5, 8 };

            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
