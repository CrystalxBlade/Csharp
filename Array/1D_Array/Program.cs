using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Array
{
    /*
     
   class Program
   {    
       static void Main(string[] args)
       {


           ----------------- Sum -----------------

           int[] arr = {2, 4, 6, 8};
           int sum = 0;

           int i = 0;
           while(i < arr.Length)
           {
               sum += arr[i];
               i++;
           }

           Console.Write($"Sum of arr is: {sum}");

           ----------------- Max -----------------

           int[] arr = { 7, 4, 6, 2, 8, 10, 5};

           int max = arr[0];
           int min = arr[0];

           for(int i = 0; i < arr.Length; i++)
           {
               if (arr[i] > max)
               {
                   max = arr[i];
               }

               if (arr[i] < min)
               {
                   min = arr[i];
               }
           }

           Console.WriteLine($"Maximum value is : {max}");
           Console.Write($"Minimum value is : {min}");

           ----------------- Reverse -----------------


           int[] arr = { 7, 4, 6, 2, 8, 10, 5 };
           int length = arr.Length;

           Console.Write("\n Original Array: ");

           for(int i = 0; i < length; i++)
           {
               Console.Write($"{arr[i]} ");
           }

           for(int i = 0; i < length / 2; i++)
           {
               int temp = arr[i];
               arr[i] = arr[length - i - 1];
               arr[length - i - 1] = temp;
           }

           Console.Write("\n Reversed Array: ");

           for(int i = 0; i < length; i++)
           {
               Console.Write($"{arr[i]} ");
           }

           Console.ReadLine();
       }


          ----------------- Reverse array using function -----------------

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 2, 6, 10, 4, 12 };
            int length = arr.Length;

            Console.Write($"\n Original Array: ");
            for(int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            reverArray(arr, length);

            Console.Write($"\n Reversed Array: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.ReadLine();
        }

        static void reverArray(int[] arr, int length)
        {
            for(int i = 0; i < length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[length - i - 1];
                arr[length - i - 1] = temp;
            }
        }

    
    }

    */
}
