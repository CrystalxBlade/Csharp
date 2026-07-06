using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            customers.Enqueue("Blade");
            customers.Enqueue("Hornet");
            customers.Enqueue("Knight");

            Console.WriteLine($"Served : {customers.Dequeue()}");
            Console.WriteLine($"Next customer: {customers.Peek()}");


            Console.WriteLine("\nWaiting customers \n");

            foreach(string customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.ReadLine();
        }
    }
}
