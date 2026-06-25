using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Using_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x,y,z) =>
            {
                return x + y + z;
            };

            double result = obj1.Invoke(2, 5.8f, 69.45);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) => 
            {
                Console.WriteLine(x + y + z);
            };

            obj2.Invoke(2, 5.8f, 69.45);

            Predicate<string> obj3 = (str) => 
            {
                if (str.Length > 5)
                    return true;
                return false;
            };

            bool val = obj3.Invoke("Crystal x Blade");
            Console.WriteLine(val);
            

            Console.ReadLine();
        }
    }
}
