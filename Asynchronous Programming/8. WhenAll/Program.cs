using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.WhenAll
{
    class Program
    {
        static async Task<string> DownloadFile(string fileName, int seconds)
        {
            Console.WriteLine($"{fileName} started");

            await Task.Delay(seconds * 1000);

            Console.WriteLine($"{fileName} Finished");

            return fileName;
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===== Task.WhenAll() =====\n");

            Task<string> task1 = DownloadFile("File 1", 8);
            Task<string> task2 = DownloadFile("File 2", 5);
            Task<string> task3 = DownloadFile("File 3", 10);

            Console.WriteLine("\nWaiting for all tasks... \n");

            string[] files = await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("\n===== All Tasks Finished =====");

            foreach(string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadLine();
        }
    }
}
