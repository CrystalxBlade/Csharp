using System;
using System.Threading.Tasks;

namespace _7.Async_Main
{
    class Program
    {
        static async Task DownloadData()
        {
            Console.WriteLine("Download Started...");

            await Task.Delay(3000);

            Console.WriteLine("Download Finished!");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===== async Main() =====");

            Console.WriteLine("Program Started");

            await DownloadData();

            Console.WriteLine("Program Finished");

            Console.ReadLine();
        }
    }
}
