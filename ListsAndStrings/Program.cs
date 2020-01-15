using System;
using System.Collections.Generic;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("cat");
            listOfStrings.Add("dog");
            listOfStrings.Add("horse");
            listOfStrings.Add("calendar");
            listOfStrings.Add("grinch");

            PrintFivePlusLetters(listOfStrings);
        }
        static void PrintFivePlusLetters(List<string> list)
        {
            foreach (string word in list)
            {
                if (word.Length >= 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
