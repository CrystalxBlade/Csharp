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
            Console.WriteLine("Default Constructor");
        }

        static void Main(string[] args)
        {

        }
    }
}
