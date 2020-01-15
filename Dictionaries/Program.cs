using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<int> studentId = new List<int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Id for " + student + ": ");
                int newId = int.Parse(Console.ReadLine());
                studentId.Add(newId);
            }

            // Print roster
            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(studentId[i] + ": " + students[i]);
            }



            Console.ReadLine();
        }
    }
}