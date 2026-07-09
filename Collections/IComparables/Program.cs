using System;
using System.Collections.Generic;


namespace IComparables
{

    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student other)
        {
            return Marks.CompareTo(other.Marks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>()
            {

            new Student { Name = "Hornet", Marks = 79},
            new Student { Name = "Knight", Marks = 89},
            new Student { Name = "Blade", Marks = 69},
            new Student { Name = "Crystal", Marks = 99}

            };

            stud.Sort();

            foreach(var students in stud)
            {
                Console.WriteLine($"{students.Name} =  {students.Marks}");
            }

            Console.ReadLine();
        }
    }
}
