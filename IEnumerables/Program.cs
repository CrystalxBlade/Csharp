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


            /*
             =================================================
              1. List<T> can be assigned to IEnumerable<T>
             =================================================
            */

            Console.WriteLine("===== List To IEnumerable =====");
            IEnumerable<Student> result = students;

            foreach(Student student in result)
            {
                Console.WriteLine(student.Name);
            }
            Console.ReadLine();
        }

    }
}
