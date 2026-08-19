using System;
using System.Threading.Tasks;

namespace _9.WhenAny
{
    class Program
    {
        static async Task<string> DownloadFile(string fileName, int seconds)
        {
            Console.WriteLine($"{fileName} Started");

            await Task.Delay(seconds * 1000);

            Console.WriteLine($"{fileName} Finished");

            return fileName;
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===== Task.WhenAny() =====\n");

            Task<string> task1 = DownloadFile("File 1", 7);
            Task<string> task2 = DownloadFile("File 2", 4);
            Task<string> task3 = DownloadFile("File 3", 9);

            Console.WriteLine("\nWaiting for the first task...\n");

            Task<string> completedTask = await Task.WhenAny(task1, task2, task3);

            Console.WriteLine($"\nFirst task completed: {completedTask.Result}");

            Console.WriteLine("\nMain Continues...");

            Console.ReadLine();

        }
    }
}
