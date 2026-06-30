using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Second number cannot be Zero.");
                }

                int result = num1 / num2;
                Console.WriteLine($"Result = {result}");
            }

            catch(FormatException)
            {
                Console.WriteLine("Please enter only number.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Unexpected Error: + {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Finished.");
            }
            Console.ReadLine();
        }
        
    }
}
