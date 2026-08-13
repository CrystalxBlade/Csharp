using System;
using System.Threading;
using System.Threading.Tasks;


namespace _6.TaskT
{
    class Program
    {

       static async Task Download()
       {
            Console.WriteLine("Download Started...");

            await Task.Delay(4000);

            Console.WriteLine("Download Finished");
       }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Before calling Download");

            await Download();

            Console.WriteLine("After calling Download");

            Console.ReadLine();
        }
        
    }
}