using System;
using System.Threading;
using System.Threading.Tasks;


namespace _6.TaskT
{
    class Program
    {

        // ================= Task =================

        static async Task PrintMessage()
        {
            await Task.Delay(1000);
            Console.WriteLine(" Hello form Task!");
        }

        // ================= Task =================

        static async Task<int> GetNumber()
        {
            await Task.Delay(2000);
            return 100;
        }


        static async Task Main(string[] args)
        {
            Console.WriteLine("|===== Task<T> ===== | \n");

            Console.WriteLine(" ===== Task ===== ");

            await PrintMessage();

            Console.WriteLine();

           // ========================================

            Console.WriteLine("===== Task<int> =====");

            int num = await GetNumber();

            Console.WriteLine($"Number : {num}");

            Console.WriteLine();

            // ========================================

            
            Console.ReadLine();
        }
    }
}