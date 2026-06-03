using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _09_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            --------------  Concat --------------

            string first = "Crystalx";
            string second = "Blade";

            string final = string.Concat(first, second);
            Console.WriteLine(final);

            string newSum = string.Concat("Crystalx", "Blade");
            Console.WriteLine(newSum);


            --------------  Empty --------------


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if(name != string.Empty)
            {
                Console.WriteLine($"Your name is: {name}");
            }
            else
            {
                Console.WriteLine("Empty string");
            }


            --------------  Equals --------------
            

            string text1 = "Crystal";
            string text2 = "Crystal";

            if(text1.Equals(text2))
            {
                Console.WriteLine($"{text1} - same texts");
            }
            else
            {
                Console.WriteLine("Different texts");
            }


            --------------  Contains --------------


            string message = "This is Crystal x Blade";
            Console.Write("Type something to search: ");

            string compare = Console.ReadLine();
            if(message.Contains(compare))
            {
                Console.WriteLine($"Found the word {compare}");
            }
            else
            {
                Console.WriteLine("Not found");
            }


            --------------  Insert --------------

            
            string message = " x Blade";

            string result = message.Insert(0, "Crystal");
            Console.Write(result);


            --------------  Replace --------------


            string message = "Crystal x Blade";

            message = message.Replace("Crystal", "Star");
            Console.WriteLine(message);


            --------------  IndexOf --------------


            string message = "Crystal x Blade";

            Console.WriteLine(message.IndexOf("x"));


            --------------  Remove --------------
            

            string message = "Crystal x Blade";

            message = message.Remove(7);          // Crystal
            message = message.Remove(2, 4);       // Crl x Blade
            Console.WriteLine(message);       


            --------------  Substring --------------

             
            string message = "Crystal x Blade";
            message = message.Substring(7);

            Console.WriteLine(message);

            Console.ReadLine();


            --------------  iterate string --------------


            string message = "Crystal x Blade";

            for(int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);

                Thread.Sleep(250);
            }


            --------------  IsNullOrEmpty --------------

            
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");


            if(!string.IsNullOrEmpty(name))
            {
                if(name.Equals("Blade"))
                {
                    Console.WriteLine("Correct");
                }
                Console.WriteLine("2");
            }


            --------------  ToString --------------
            

            int num = 4;

            string value = num.ToString();

            Console.WriteLine(value);



            --------------  ToLower & Upper --------------
            */

            string n1 = "BLADE";
            string n2 = "crystal";

            n1 = n1.ToLower();
            n2 = n2.ToUpper();

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            Console.ReadLine();
        }
    }
}
