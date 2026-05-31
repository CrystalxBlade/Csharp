using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ref_n_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;

            something(ref num);

            Console.WriteLine(num);

            Console.ReadLine();
        }

        static void something(ref int a)
        {
            a += 10;
            Console.WriteLine($" method value = {a}");
        }
    }
}
