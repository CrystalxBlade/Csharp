using System;
using System.Threading;
using System.Threading.Tasks;


namespace _6.TaskT
{
    class Program
    {

        static async Task PrintMessage()
        {
            Console.WriteLine("Task started...");

            await Task.Delay(3000);

            Console.WriteLine("Task Finished");
        }

        static void Main(string[] args)
        {
            Task t = PrintMessage();

            //t.Wait();

            Console.WriteLine("\nMain Method Finished");

            Console.ReadLine();
        }
    }
}