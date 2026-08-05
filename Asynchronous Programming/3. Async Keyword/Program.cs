using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Async_Keyword
{
    class Program
    {
        static async Task PrintMessage()
        {
            Console.WriteLine("Method Started");

            await Task.Delay(2000);

            Console.WriteLine("Method Finished");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== async Keyword ====\n");

            Task task = PrintMessage();

            task.Wait();

            Console.WriteLine("\nMain Method Finished");

            Console.ReadLine();
        }
    }
}
