using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Static_Non_Static
{
    class Testing
    {
        public static void something()
        {
            Console.WriteLine("Something");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Testing.something();

            Welcome();
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome Blade");
        }
    }
}
