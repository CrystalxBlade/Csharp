using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Static_Non_Static
{
    class Blade
    {
        public void Player()
        {
            Console.WriteLine("Player health 90% ");
        }
    }
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
            Blade b = new Blade();
            b.Player();

            Testing.something();

            Welcome();
            Console.ReadLine();
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome Blade");
        }
    }


    // static = belongs to class 
    // Non static = belongs to object
}
