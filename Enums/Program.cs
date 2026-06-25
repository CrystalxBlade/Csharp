using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum Days
        {
            Monday = 2,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday = 69,
            Sunday
        }

        static void Main(string[] args)
        {
            Days d = Days.Wednesday;

            Console.WriteLine($"Today is {d}");
            Console.WriteLine($"Numeric value is: {(int)d}");

            Console.WriteLine("----------------------------");

            // Printing values of all the Enums

            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i);

            Console.WriteLine("----------------------------");

            // Printing names of all the Enums

            foreach (string n in Enum.GetNames(typeof(Days)))
                Console.WriteLine(n);

            Console.WriteLine("----------------------------");

            // Printing name with values of all the Enums

            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine($"{i} : {(Days)i}");

            Console.ReadLine();
        }
    }
}
