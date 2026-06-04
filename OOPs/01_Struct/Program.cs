using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    struct Person
    {
        public string name;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person;

            person.name = "Blade";
            person.age = 24;
        }
    }
}
