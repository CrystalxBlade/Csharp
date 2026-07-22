using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public static class MyExtension
    {
        // Example 1: Extension Method for string

        public static void Print(this string text)
        {
            Console.WriteLine(text);
        }

        // Example 2: Extension Method with Return Value

        public static string ReverseText(this string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
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

            //====================================
            // Example 2: ReverseText()
            //====================================

            Console.WriteLine("===== Reverse Text =====");

            string text = "Crystal";

            Console.WriteLine(text.ReverseText());

            Console.WriteLine();

            //====================================
            // Example 3: IsEven()
            //====================================

            Console.WriteLine("===== IsEven() =====");

            int num = 10;

            Console.WriteLine(num.IsEven());

            Console.ReadLine();
        }
    }
}
