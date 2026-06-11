using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            int[] arr = {2, 4, 6, 8};
            int sum = 0;

            int i = 0;
            while(i < arr.Length)
            {
                sum += arr[i];
                i++;
            }

            Console.Write($"Sum of arr is: {sum}");

            */

            int[] arr = { 2, 4, 6, 8, 10, 5, 1};

            int max = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.Write($"Maximum value is : {max}");

            Console.ReadLine();
        }
    }
}
