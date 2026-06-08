using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism
{
    class Program
    {
        void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        void Add(int a, int b, int c)
        {
            Console.WriteLine($"Overload by number of parameters: {a + b + c}");
        }
        void Add(string name, float x)
        {
            Console.WriteLine($"Overload by type of parameters:{name} : {x}");
        }
        void Add(float x, string name)
        {
            Console.WriteLine($"Overload by order of parameters: {x} : {name}");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add(2, 4);
            p.Add(2, 4, 6);
            p.Add("Blade", 24);
            p.Add(24, "Blade");

            Console.ReadLine();
        }
    }
}
