using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public static class MyExtension
    {
        public static void Print(this string text)
        {
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //====================================
            // Example 1: Print()
            //====================================

            Console.WriteLine("===== Print =====");
            string name = "Blade";
            name.Print();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
