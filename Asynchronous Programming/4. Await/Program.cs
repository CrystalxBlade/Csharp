using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Await
{
    class Program
    {
        static async Task DownloadData()
        {
            Console.WriteLine("Download Started...");
            await Task.Delay(3000);
            Console.WriteLine("Download Finished");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===== await keyword Method =====\n");

            Console.WriteLine("Before Calling Method");

            await DownloadData();

            Console.WriteLine("After Calling Method");

            Console.ReadLine();
        }
    }
}
