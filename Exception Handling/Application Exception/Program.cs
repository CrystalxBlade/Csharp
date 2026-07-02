using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Exception
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int y = int.Parse(Console.ReadLine());

            if(y % 2 > 0)
            {
                // throw new ApplicationException("Divisor value cannot be odd no");
                throw new DivideByOddNoException();
            }
            int z = x / y;

            Console.WriteLine($"Result is : {z}");

            Console.ReadLine();
        }
    }
}
