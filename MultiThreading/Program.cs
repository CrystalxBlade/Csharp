using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MultiThreading
{
    class Program
    {
        /*
         
        =========================================
        1. Creating a Thread
        =========================================
        
        
        Definition:
        A Thread is the smallest unit of execution inside a process.
        
        
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
            Console.WriteLine("Main Thread Finished");

            Console.ReadLine();
        }

        =========================================
        2. Multiple Threads
        =========================================

        static void PrintNumb()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Thread 1 : {i}");
                Thread.Sleep(500);
            }
        }

        static void PrintLetters()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine($"Thread 2 : {ch}");
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintNumb);
            Thread t2 = new Thread(PrintLetters);

            t1.Start(); 
            t2.Start(); 

            Console.ReadLine();
        }

        ==================================================
        3. Thread.Sleep()
        ==================================================


        Definition:
        Temporarily pauses the current thread for a specified amount of time.


        static void SleepExample()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Count: {i}");

                // Pause the current thread for 1 second
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Thread.Sleep() =====\n");

            SleepExample();

            Console.WriteLine("\nLoop Finished");

            Console.ReadLine();
        }


        ==================================================
         4. Thread.Join()
        ==================================================


        Definition:
        Join() blocks the calling thread until the target thread finishes execution.


        static void PrintNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Thread Join =====\n");

            Thread t = new Thread(PrintNumbers);

            t.Start();

            Console.WriteLine("Main thread is waiting...\n");

            t.Join();    // Wait until PrintNumber() finishes

            Console.WriteLine("\nWorker Thread Finished");
            Console.WriteLine("Main Thread Finished");

            Console.ReadLine();
        }


        ==================================================
         5. Passing Parameters
        ==================================================


        static void PrintTable(object number)
        {
            int num = (int)number;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
                Thread.Sleep(300);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("====== Passing Parameters =====\n");

            Thread t = new Thread(PrintTable);

            t.Start(5);

            t.Join();

            Console.WriteLine("\nThread Finished");

            Console.ReadLine();

        }

        
        ==================================================
        6. Foreground vs Background Thread
        ==================================================



        Foreground Thread

        Definition:
        A Foreground Thread keeps the application running until it finishes execution.
        
        Default:
        Every new thread is a Foreground Thread.
        
        Background Thread
        
        Definition:
        A Background Thread automatically stops when all Foreground Threads have finished.


        

        static void PrintNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Worker Thread : {i}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Foreground vs Background Thread =====\n");

            Thread t = new Thread(PrintNumbers);

            // Make it a Background Thread
            t.IsBackground = true;

            t.Start();

            Console.WriteLine("Main Thread Finished \n");

            Console.ReadLine();
        }


        ==================================================
         7. Race Condition
        ==================================================


        Definition:

        A Race Condition occurs when two or more threads access and 
        modify shared data simultaneously, causing unpredictable results.


        class Bank
        {
            static int counter = 0;

            static void Increment()
            {
                for(int i = 1; i <= 100000; i++)
                {
                    counter++;
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("===== Race Condition =====\n");

                Thread t1 = new Thread(Increment);
                Thread t2 = new Thread(Increment);

                t1.Start();
                t2.Start();

                t1.Join();
                t2.Join();

                Console.WriteLine($"Counter = {counter}");

                Console.ReadLine();
            }
        }


        ==================================================
         8. lock Keyword
        ==================================================


        */

        static int counter = 0;

        // Object used for locking

        static readonly object lockObject = new object();

        static void Increment()
        {
            for(int i = 1; i <= 100000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
                
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== lock keyword =====\n");

            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Counter {counter}");

            Console.ReadLine();
        }
    }
}
