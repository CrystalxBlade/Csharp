using System;
using System.Collections.Generic;

namespace IComparers
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class SortByName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>()
            {

            new Student { Name = "Crystal", Marks = 99 },
            new Student { Name = "Hornet", Marks = 79 },
            new Student { Name = "Blade", Marks = 69 },
            new Student { Name = "Knight", Marks = 89 },

            };

            stud.Sort(new SortByName());

            foreach(var student in stud)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }

            Console.ReadLine();
        }
    }
}
