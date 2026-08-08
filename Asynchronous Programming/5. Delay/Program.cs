using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Delay
{
    class Program
    {
        static async Task DelayExample()
        {
            Console.WriteLine("Task.Delay Started... \n");

            // Non-blocking delay for 3 seconds
            await Task.Delay(3000);

            Console.WriteLine("Task.Delay Finished");

        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===== Task.Delay() ===== \n");

            Console.WriteLine("Before Delay");

            await DelayExample();

            Console.WriteLine("After Delay");

            Console.ReadLine();
        }
    }
}
