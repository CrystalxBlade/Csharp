using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {

        static void DoWork()
        {
            Console.WriteLine("Task Started...");

            Thread.Sleep(3000); // Simulate work

            Console.WriteLine("Task Finished");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Task =====\n");

            Task task = Task.Run(DoWork);

            Console.WriteLine("Main Method Continue...");

            task.Wait();

            Console.WriteLine("\nAll Work Completed");

            Console.ReadLine();
        }
    }
}
