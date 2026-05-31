using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ref_n_Out
{
    class Program
    {
        
        /*                  // ref
                            
         
        static void Main(string[] args)
        {
            int num = 20;                    // must initialize first

            something(ref num);

            Console.WriteLine(num);

            Console.ReadLine();
        }

        static void something(ref int a)
        {
            a += 10;
        }

        */
        
                            // out

        /*
        static void Main(string[] args)
        {
            int x;                          // no initialization needed
            GetValue(out x);
            Console.WriteLine(x);

            Console.ReadLine();
        }

        static void GetValue(out int x)
        {
            x = 5;                         // must assign inside method
        }
        */
    }
}
