using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    public delegate string GreetingsDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            GreetingsDelegate obj = delegate (string name)
            {
                return $"Hello {name} very good morning";
            };

            string str = obj.Invoke("Blade");

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
