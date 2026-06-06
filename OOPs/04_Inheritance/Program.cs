using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance
{
    /*
     
            -------------- Single Inheritance --------------
     
    class Crystal
    {
        public void Derived()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Blade : Crystal
    {
        public void Base()
        {
            Console.WriteLine("Base class");
        }

        static void Main(string[] args)
        {
            Blade b = new Blade();
            b.Base();
            b.Derived();

            Console.ReadLine();
        }
    }


           -------------- Multilevel Inheritance --------------
    

    class Crystal
    {
        public void Disp1()
        {
            Console.WriteLine("Crystal");
        }
    }
    class Blade : Crystal
    {
        public void Disp2()
        {
            Console.WriteLine("Blade");
        }
    }
    class Skull : Blade
    {
        public void Disp3()
        {
            Console.WriteLine("Skull");
        }

        static void Main(string[] args)
        {
            Skull s = new Skull();
            s.Disp1();
            s.Disp2();
            s.Disp3();

            Console.ReadLine();
        }
    }

    */

    class Crystal
    {
        public void Hornet()
        {
            Console.WriteLine("Hornet is Dashing");
        }
    }
    class Skull : Crystal
    {
        public void Knight()
        {
            Console.WriteLine("Knight is slashing");
        }
    }
    class Blade : Crystal
    {
        public void Player()
        {
            Console.WriteLine("Blade is Playing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Skull s = new Skull();
            s.Hornet();               // Inherited from Crystal
            s.Knight();               // Own Method

            Blade b = new Blade();
            b.Hornet();               // Inherited form Crystal
            b.Player();               // Own Method

            Console.ReadLine();
        }
    }
}
