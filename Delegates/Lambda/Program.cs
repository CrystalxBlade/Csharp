using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate string GreetingsDelegate(string name);
    class Program
    {
        public static string Greetings(string name)
        {
            return $"Hello {name} very good morning";
        }
        static void Main(string[] args)
        {
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);

            string str = obj.Invoke("Blade");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
