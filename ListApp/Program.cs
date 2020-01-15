using System;
using System.Collections.Generic;
using System.Linq;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);
            numList.Add(5);
            numList.Add(6);
            numList.Add(7);
            numList.Add(8);
            numList.Add(9);
            numList.Add(10);

            Console.WriteLine(ListSum(numList));
            Console.ReadLine();
        }

        static int ListSum(List<int> list)
        {
            int sum = list.Sum();
            return sum;
        }
    }
}
