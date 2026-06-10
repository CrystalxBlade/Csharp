using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Mustang", "Corvette" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            Console.ReadLine();
        }

        */

        static void Main(string[] args)
        {
            string[] car = {"Mercedes", "BMW", "Porsche", "Audi"};

            for(int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            Console.ReadLine();
        }
    }
}
