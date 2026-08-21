using System;
using System.Threading.Tasks;

namespace _10.AsyncException
{
    class Program
    {

        static async Task DownloadData()
        {
            Console.WriteLine("Download Started...");

            await Task.Delay(2000);

            throw new Exception("Download Failed");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===== Exception Handling =====\n");

            try
            {
                await DownloadData();

                Console.WriteLine("Download Successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            Console.WriteLine("\nProgram Continued...");

            Console.ReadLine();
        }
    }
}
