using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interface
{
    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The Rabbit runs away");
        }
    }
    class Hawk
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rabbit r = new Rabbit();
            r.Flee();

            Console.ReadLine();
        }
    }
}
