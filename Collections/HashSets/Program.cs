using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(10);

            foreach(int numb in numbers)
            {
                Console.WriteLine(numb);
            }

            Console.WriteLine($"\nContains 20: {numbers.Contains(20)}");

            numbers.Remove(20);

            Console.WriteLine("\nAfter Removing");

            foreach(int numb in numbers)
            {
                Console.WriteLine(numb);
            }

            Console.ReadLine();
        }
    }
}
