using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2016;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Not Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Not Leap Year"); // ✅ handles years not divisible by 4
            }

            Console.ReadLine(); // ✅ moved outside — always runs
        }
    }
}
