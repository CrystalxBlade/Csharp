using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the char: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Not a letter");
            }

            Console.WriteLine(ch);

            Console.ReadLine();
        }
    }
}
