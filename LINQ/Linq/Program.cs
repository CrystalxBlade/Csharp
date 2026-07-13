using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ID = 1, Name = "Blade", Age = 24, Marks = 80},
                new Student{ID = 2, Name = "Hornet", Age = 22, Marks = 95},
                new Student{ID = 3, Name = "Knight", Age = 23, Marks = 70},
                new Student{ID = 4, Name = "Crystal", Age = 21, Marks = 85}
            };

            // Where
            Console.WriteLine("WHERE");
            var whenResult = students.Where(s => s.Marks >= 80);

            foreach(var student in whenResult)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }

            Console.ReadLine();
        }
    }
}
