using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);

    class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad.Invoke(2, 4);

            SayDelegate sd = new SayDelegate(Program.SayHello);
            string str = sd.Invoke("Blade");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
