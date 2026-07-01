using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string val = (num > 10) ? "Greater" : "Smaller";
            Console.WriteLine(val);

            Console.ReadLine();
        }
    }
}
