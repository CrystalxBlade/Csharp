using System;
using System.Threading;
using System.Threading.Tasks;


namespace _6.TaskT
{
    class Program
    {

        static void Player1()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void Player2()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine(ch);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Player1);
            Thread t2 = new Thread(Player2);

            t1.Start();
            

            t2.Start();
            

            Console.WriteLine("Main thread Completed...");

            Console.ReadLine();
        }
    }
}
