using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ID = 1, Name = "Blade", Marks = 69},
                new Student{ID = 2, Name = "Crystal", Marks = 79}
            };


            Console.WriteLine("===== List To IEnumerable =====");

            IEnumerable<Student> result = students;

            foreach(Student student in result)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();

            Console.WriteLine("===== LINQ Returns IEnumerable =====");

            IEnumerable<Student> passedStudents =
                students.Where(s => s.Marks >= 80);

            foreach(Student stud in passedStudents)
            {
                Console.WriteLine(stud.Name);
            }

            Console.WriteLine();

            Console.WriteLine("===== Array =====");
            Student[] array =
            {
                new Student(){ID = 6, Name = "ALice", Marks = 91},
                new Student(){ID = 7, Name = "David", Marks = 75}
            };

            IEnumerable<Student> arrayStudents = array;

            foreach(Student stud in arrayStudents)
            {
                Console.WriteLine(stud.Name);
            }

            Console.ReadLine();
        }

    }
}
