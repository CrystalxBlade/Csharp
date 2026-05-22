using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer
            int health = 100;

            // Decimal number
            float speed = 5.5f;

            // More precise decimal
            double accuracy = 99.99;

            // True or false
            bool isAlive = true;

            // Single character
            char grade = 'A';

            // Text
            string playerName = "Blade";

            // Auto detect type
            var level = 10;

            Console.WriteLine("=== PLAYER DATA ===");

            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Accuracy: " + accuracy);
            Console.WriteLine("Alive: " + isAlive);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Level: " + level);

            Console.ReadLine();
        }
    }
}
