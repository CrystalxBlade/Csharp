using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_User_Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRING INPUT
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            // INTEGER INPUT
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // FLOAT INPUT
            Console.Write("Enter your speed: ");
            float speed = Convert.ToSingle(Console.ReadLine());

            // BOOLEAN INPUT
            Console.Write("Are you alive? (true/false): ");
            bool isAlive = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("=== PLAYER INFO ===");

            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Alive: " + isAlive);

            Console.ReadLine();
        }
    }
}
