using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Synchronous Programming =====\n");

            Console.WriteLine("Step 1: Start Download");

            // Blocks the current thread
            Thread.Sleep(3000);

            Console.WriteLine("Step 2: Download Finished");

            Console.WriteLine();
            Console.WriteLine("Press Enter to see Asynchronous Programming...");
            Console.ReadLine();

            Console.WriteLine("===== Asynchronous Programming =====\n");

            AsyncExample().Wait();

            Console.WriteLine("\nProgram Finished");

            Console.ReadLine();
        }

        static async Task AsyncExample()
        {
            Console.WriteLine("Step 1: Start Downloading");

            // Doesn't block the current thread

            await Task.Delay(3000);

            Console.WriteLine("Step 2: Download Finished");

        }
    }
}