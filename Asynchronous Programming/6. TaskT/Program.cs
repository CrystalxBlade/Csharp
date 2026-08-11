using System;
using System.Threading;
using System.Threading.Tasks;


namespace _6.TaskT
{
    class Program
    {

        static void SomeMethod()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Task: {i}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Task t = Task.Run(SomeMethod);

            Console.WriteLine("Task is Running...\n");

            t.Wait();

            Console.WriteLine("\nMain Method Exit");

            Console.ReadLine();
        }
      
    }
}
