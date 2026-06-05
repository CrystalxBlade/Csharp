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
            Console.WriteLine($"Parameterized Constructor: {name} {age}");
        }

        public Crystal(Crystal obj)
        {
            this.name = obj.name;
            this.age = obj.age;
            Console.WriteLine($"Copyt Constructor: {name} {age}");
        }
        
        static void Main(string[] args)
        {
            Crystal c = new Crystal();
            Crystal c1 = new Crystal("Blade", 24);
            Crystal c2 = new Crystal(c1);

            Console.WriteLine();

            Console.WriteLine("--- After Copy ---");
            Console.WriteLine($"c1 -> name: {c1.name} age: {c1.age}");
            Console.WriteLine($"c2 -> name: {c2.name} age: {c2.age}");

            Console.WriteLine();
            Console.WriteLine("--- Modify c2 ---");

            c2.name = "Crystal";
            c2.age = 23;

            Console.WriteLine($"c1 -> name: {c1.name} age: {c1.age}");
            Console.WriteLine($"c2 -> name: {c2.name} age: {c2.age}");

            Console.ReadLine();
        }
    }
}
