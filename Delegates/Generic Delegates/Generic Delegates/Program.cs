using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates
{
    class Program
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Crystal Blade");
            Console.WriteLine(status);

            Console.ReadLine();
        }
    }
}
