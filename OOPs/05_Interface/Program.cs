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
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }
    class Fish : IPrey,IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rabbit r = new Rabbit();
            r.Flee();

            Hawk h = new Hawk();
            h.Hunt();

            Fish f = new Fish();
            f.Flee();
            f.Hunt();

            Console.ReadLine();
        }
    }
}
