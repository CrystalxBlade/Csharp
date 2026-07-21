using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Student{ID = 1, Name = "Blade",   Marks = 69},
                new Student{ID = 2, Name = "Crystal", Marks = 79},
                new Student{ID = 3, Name = "Alex",    Marks = 70},
                new Student{ID = 4, Name = "Steve",   Marks = 85},
                new Student{ID = 5, Name = "Bob",     Marks = 60}
            };

            //=================================================
            // 1. List<T> can be assigned to IEnumerable<T>
            //=================================================


            Console.WriteLine("===== List To IEnumerable =====");

            IEnumerable<Student> result = students;

            foreach (Student student in result)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();

            //=================================================
            // 2. IEnumerable returned by LINQ
            //=================================================

            Console.WriteLine("===== LINQ Returns IEnumerable =====");

            IEnumerable<Student> passedStudents =
                students.Where(s => s.Marks >= 80);

            foreach (Student stud in passedStudents)
            {
                Console.WriteLine(stud.Name);
            }

            Console.WriteLine();

            //=================================================
            // 3. IEnumerable can work with Arrays
            //=================================================

            Console.WriteLine("===== Array =====");
            Student[] array =
            {
                new Student(){ID = 6, Name = "ALice", Marks = 91},
                new Student(){ID = 7, Name = "David", Marks = 75}
            };

            IEnumerable<Student> arrayStudents = array;

            foreach (Student stud in arrayStudents)
            {
                Console.WriteLine(stud.Name);
            }

            Console.WriteLine();

            //=================================================
            // 4. IEnumerable can work with HashSet
            //=================================================

            Console.WriteLine("===== Hashset =====");

            HashSet<Student> hash = new HashSet<Student>()
            {
                new Student(){ID = 8, Name = "Knight", Marks = 77},
                new Student(){ID = 9, Name = "Shakra", Marks = 92}
            };

            foreach (Student stud in hash)
            {
                Console.WriteLine(stud.Name);
            }

            //=================================================
            // 5. Method Parameter
            //=================================================

            Console.WriteLine("");

            Console.WriteLine("===== Method Parameter =====");

            DispalyStudents(students);

            Console.WriteLine();

            //=================================================
            // 6. Method Return Type
            //=================================================

            Console.WriteLine("===== Method Return Type =====");

            IEnumerable<Student> topStudents = GetTopStudents(students);

            foreach (Student stud in topStudents)
            {
                Console.WriteLine(stud.Name);
            }

            Console.WriteLine();

            //=================================================
            // 7. Deferred Execution
            //=================================================

            Console.WriteLine("===== Deferred Execution =====");

            IEnumerable<Student> query =
                students.Where(s => s.Marks >= 80);

            foreach (Student stud in query)
            {
                Console.WriteLine(stud.Name);
            }

            students.Add(new Student()
            {
                ID = 10,
                Name = "Mike",
                Marks = 82
            });

            Console.WriteLine();

            //=================================================
            // 8. Immediate Execution
            //=================================================

            Console.WriteLine("===== Immediate Execution =====");

            List<Student> list =
                students.Where(s => s.Marks >= 80).ToList();

            students.Add(new Student()
            {
                ID = 11,
                Name = "Kevin",
                Marks = 90
            });

            foreach(Student stud in list)
            {
                Console.WriteLine(stud.Name);
            }

            Console.WriteLine();

            //=================================================
            // 9. IEnumerable is Read Only
            //=================================================

            Console.WriteLine("===== Read Only =====");

            IEnumerable<Student> readOnly = students;

            Console.WriteLine("IEnumerable does not have ADD(), " +
                "REMOVE() or INSERT().");

            Console.ReadLine();
        }

        static void DispalyStudents(IEnumerable<Student> students)
        {
            foreach(Student stud in students)
            {
                Console.WriteLine(stud.Name);
            }
        }

        static IEnumerable<Student> GetTopStudents(List<Student> students)
        {
            return students.Where(s => s.Marks >= 80);
        }

    }
}
