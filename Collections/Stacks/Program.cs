using System;
using System.Collections.Generic;


namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();

            books.Push("Book 1");
            books.Push("Book 2");
            books.Push("Book 3");

            Console.WriteLine($"Top book: {books.Peek()}");

            Console.WriteLine($"Removed: {books.Pop()}");

            Console.WriteLine("\nRemaining Books:");

            foreach(string book in books)
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();
        }
    }
}
