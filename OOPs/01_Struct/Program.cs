using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    /*
    
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

            Console.WriteLine($"{person.name} - {person.age}");

            Console.ReadLine();
        }
    }

    

    ------------------------------------------------------------------


    
      
    struct Person
    {
        public string name;
        public int age;
        public int birthMonth;
    }

    class Crystal
    {
        static void Main(string[] args)
        {
            Person p = Details();
            Console.WriteLine($"{p.name} - {p.age} - {p.birthMonth}");

            Console.ReadLine();
        }

        static Person Details()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Person person;

            person.name = name;
            person.age = age;
            person.birthMonth = birthMonth;

            return person;
        }
    }

    */

    struct Person
    {
        public string name;
        public int age;
        public int birthMonth;

        public Person(string name, int age, int birthMonth)
        {
            this.name = name;
            this.age = age;
            this.birthMonth = birthMonth;
        }
    }

    class Crystal
    {
        static void Main(string[] args)
        {
            Person p = Details();

            Console.WriteLine($"{p.name} - {p.age} - {p.birthMonth}");

            Console.ReadLine();
        }

        static Person Details()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age =  Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());


            return new Person(name, age, birthMonth);
        }
    }
}
