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
              
            // Count Digits
            
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
            

            // Factorial

            int num = 5;
            int factorial = 1;

            if(num < 0)
            {
                Console.WriteLine("Factorial does not exist for negative numbers");
            }
            else if(num == 0)
            {
                Console.WriteLine("Factorial of 0 is 1");
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    factorial *= i;
                    Console.WriteLine(factorial);
                }
                Console.WriteLine($"Factorial of {num} is : {factorial}");
            }

            // Palindrome

            int num = 12321;
            int original = num;
            int reversed = 0;

            if(num < 0)
            {
                Console.WriteLine("Negative numbers are not palindrome");
            }
            else
            {
                while(num > 0)
                {
                    int lastdigit = num % 10;
                    reversed = reversed * 10 + lastdigit;
                    num = num / 10;
                }

                if (original == reversed)
                {
                    Console.WriteLine($"{original} is a palindrome");
                }
                else
                {
                    Console.WriteLine($"{original} is not a palindrom");
                }
            }

            // Largest digit 

            int num = 47392;
            int largest = 0;

            if(num < 0)
            {
                num = -num;
            }

            if(num == 0)
            {
                Console.WriteLine("Largest digit is: 0");
            }
            else
            {
                while(num > 0)
                {
                    int lastdigit = num % 10;
                    if(lastdigit > largest)
                    {
                        largest = lastdigit;
                    }
                    num = num / 10;
                }
                Console.Write($"Largest digit is : {largest}");
            }

            // Fibonacci

            int n = 10, first = 0, second = 1, count = 1; 

            if(n <= 0)
            {
                Console.WriteLine("Enter a positive number");
            }
            else if(n == 1)
            {
                Console.WriteLine("Fibonacci Series 0");
            }
            else
            {
                Console.Write("Fibonacci Series: ");

                while(count <= n)
                {
                    Console.Write($"{first} ");

                    int next = first + second;
                    first = second;
                    second = next;

                    count++;
                }

            }

            // Check Prime number

            int num = 7;
            bool isPrime = true;
            int i = 2;

            if(num <= 1)
            {
                isPrime = false;
            }
            else
            {
                while(i < num)
                {
                    if(num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime");
            }

            // Print all Prime number 1 to 100
            
            for(int num = 1; num <= 100; num++)
            {
                int count = 0;

                for(int i = 1; i <= num; i++)
                {
                    if(num % i == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    Console.WriteLine(num);
                }
            }

            */
            Console.ReadLine();
        }
    }
}
