using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Emma", 1, 9, 3.4);
            Student student2 = new Student("Claire", 2, 12, 3.9);

            List<Student> classList = new List<Student>();
            classList.Add(student1);
            classList.Add(student2);

            Course course1 = new Course();
            course1.Students = classList;
            course1.Instructor = "Mark Z";
            course1.CourseName = "Internet 101";
            course1.CourseId = 12;

            Console.WriteLine(student2.ToString());
            Console.WriteLine(course1.ToString());
        }
    }

    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double qualityScore;

            if (grade > 89.5)
            {
                qualityScore = 4.0 * courseCredits;
            }
            else if (grade > 79.5)
            {
                qualityScore = 3.0 * courseCredits;
            }
            else if (grade > 69.5)
            {
                qualityScore = 2.0 * courseCredits;
            }
            else if (grade > 59.5)
            {
                qualityScore = 1.0 * courseCredits;
            }
            else
            {
                qualityScore = 0;
            }

            double oldQualityScore = Gpa * NumberOfCredits;

            NumberOfCredits += courseCredits;

            Gpa = (oldQualityScore + qualityScore) / NumberOfCredits;
            
        }

        public string GetGradeLevel()
        {
            string gradeLevel;

            if (NumberOfCredits < 30 && NumberOfCredits >= 0)
            {
                gradeLevel = "freshman";
            }
            if (NumberOfCredits < 60 && NumberOfCredits >= 30)
            {
                gradeLevel = "sophomore";
            }
            if (NumberOfCredits < 90 && NumberOfCredits >= 60)
            {
                gradeLevel = "junior";
            }
            if (NumberOfCredits >= 90)
            {
                gradeLevel = "senior";
            }
            else
            {
                gradeLevel = "error";
            }

            return gradeLevel;
        }

        public override bool Equals(Object o)
        {

            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }

        public override int GetHashCode()
        {
            return StudentId;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
    }

    class Course
    {
        public List<Student> Students { get; set; }
        public string Instructor { get; set; }
        public string CourseName { get; set; }
        public int CourseId { get; set; }

        public override bool Equals(Object o)
        {

            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            Course courseObj = o as Course;
            return CourseId == courseObj.CourseId;
        }

        public override int GetHashCode()
        {
            return CourseId;
        }

        public override string ToString()
        {
            return CourseName + " (Instructor: " + Instructor + " , Class Size: " + Students.Count + ")";
        }

    }

}
