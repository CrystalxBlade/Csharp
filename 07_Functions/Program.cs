using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet();

            Greetings("Blade");

            int result = Multiply(2, 4);
            Console.WriteLine(result);

            Console.WriteLine(Crystals());

            Console.ReadLine();
        }

        static void Greet()
        {
            Console.WriteLine("Greetings");
        }

        static void Greetings(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Crystals()
        {
            return 2015;
        }
    }
}
