using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MultiThreading
{
    class Program
    {
        static void PrintNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Thread: {i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Creating Thread ===== \n");

            Thread t = new Thread(PrintNumbers);
            t.Start();

            Console.ReadLine();
        }
    }
}
