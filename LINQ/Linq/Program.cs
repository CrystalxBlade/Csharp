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

            // WHERE

            Console.WriteLine("=== WHERE === \n");
            var whenResult = students.Where(s => s.Marks >= 80);

            foreach(var student in whenResult)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }

            Console.WriteLine();

            // SELECT

            Console.WriteLine("=== SELECT === \n");
            var selectResult = students.Select(s => s.Name);

            foreach(var name in selectResult)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // ORDER

            Console.WriteLine("=== ORDERBY === \n");
            var orderResult = students.OrderBy(s => s.Name);

            foreach(var student in orderResult)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();

            // OrderByDescending

            Console.WriteLine("=== OrderByDescending === \n");
            var descResult = students.OrderByDescending(s => s.Name);

            foreach(var desc in descResult)
            {
                Console.WriteLine(desc.Name);
            }

            Console.WriteLine();

            // FIRST

            Console.WriteLine("=== FIRST ===");
            var first = students.First(s => s.Marks >= 80);

            Console.WriteLine($"{first.Name} - {first.Marks}");

            Console.WriteLine();

            // FIRSTORDEFAULT

            Console.WriteLine("=== FIRSTDEFAULT === \n");
            var firstDefault = students.FirstOrDefault(s => s.Name == "Nikko");

            if (firstDefault != null)
                Console.WriteLine(firstDefault.Name);
            else
                Console.WriteLine("Student Not Found");

            Console.WriteLine();

            // COUNT

            Console.WriteLine("=== COUNT=== ");
            Console.WriteLine(students.Count());

            Console.WriteLine();

            // ANY

            Console.WriteLine("===== ANY =====");
            Console.WriteLine(students.Any(s => s.Marks > 90));

            Console.WriteLine();

            // ALL

            Console.WriteLine("===== ALL =====");
            Console.WriteLine(students.All(s => s.Marks >= 60));

            Console.WriteLine();

            // SUM 

            Console.WriteLine("===== SUM =====");
            Console.WriteLine($"Total Marks : {students.Sum(s => s.Marks)}");

            Console.WriteLine();

            // AVERAGE
            
            Console.WriteLine("===== AVERAGE =====");
            Console.WriteLine($"Average Marks : {students.Average(s => s.Marks)}");

            Console.WriteLine();

            // MAX 

            Console.WriteLine("===== MAX =====");
            Console.WriteLine($"Highest Marks : {students.Max(s => s.Marks)}");

            Console.WriteLine();

            // MIN 

            Console.WriteLine("===== MIN =====");
            Console.WriteLine($"Lowest Marks : {students.Min(s => s.Marks)}");

            Console.WriteLine();

            // GROUPBY

            Console.WriteLine("=== GROUPBY ===");

            var groups = students.GroupBy(s => s.Marks >= 80);

            foreach(var grp in groups)
            {
                Console.WriteLine(grp.Key ? "Passed" : "Failed");

                foreach(var student in grp)
                {
                    Console.WriteLine($"{student.Name} - {student.Marks}");
                }
                Console.WriteLine();
            }

            // SKIP

            Console.WriteLine("=== SKIP === \n");

            var skip = students.Skip(2);

            foreach(var student in skip)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();

            // TAKE

            Console.WriteLine("=== TAKE === \n");

            var take = students.Take(2);

            foreach(var student in take)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();

            // TOLIST

            Console.WriteLine("=== TOLIST === \n");

            List<Student> list = students
                .Where(s => s.Marks >= 80)
                .ToList();

            foreach(var student in list)
      
                Console.WriteLine(student.Name);
               

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
