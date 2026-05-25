using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              
            int num = 5279;
            int count = 0;

            if(num< 0)
            {
                num = -num;
            }
            if(num == 0)
            {
                count = 1;
            }
            else
            {
                while(num > 0)
                {
                    num = num / 10;
                    count++;
                }
            }
            Console.WriteLine($"Number of digits : {count}");
            */

            int num = 5;
            int factorial = 1;

            if(num < 0)
            {
                Console.WriteLine("Factorial does not exist for negative numbers");
            }
            else if(num == 0)
            {
                Console.WriteLine("Factorial");
            }

            Console.ReadLine();
        }
    }
}
