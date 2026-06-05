using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Class_Constructor
{
    class Crystal
    {
        public string name;
        public int age;

        public Crystal()
        {
            Console.WriteLine("Default Constructor");
        }

        public Crystal(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"Parameterized Constructor {name} {age}");
        }
        
        static void Main(string[] args)
        {
            Crystal c = new Crystal();
            Crystal c1 = new Crystal("Blade", 24);

            Console.ReadLine();
        }
    }
}
