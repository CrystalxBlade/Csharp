using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        // List = datat structures that represents the list of objects that can be accessed by index.
        //        Similar to array, but can dynamically increase/ decrease in size
        //        using System. Collections.Generic;
        static void Main(string[] args)
        {
            /*
             
             ----------------- Add / Remove -----------------

            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            food.Remove("Fries");

            ----------------- Insert / Count -----------------

            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            food.Insert(2, "Sushi");
            
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(food.Count);


            ----------------- Index Of / Contains -----------------
            

            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            Console.WriteLine(food.IndexOf("Hotdog"));

            Console.WriteLine(food.Contains("Fries"));


            ----------------- Sort / Reverse -----------------

            */

            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            // food.Sort();
            // food.Reverse();

            foreach(string item in food)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
