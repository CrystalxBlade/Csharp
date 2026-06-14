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


    class Program
    {
        /*
            ----------------- Find x at n index -----------------

        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 9, 1, 7 };

            int i = 0;
            int x = 1;
            bool find = false;
            int foundIndex = -1;
            
            while(i < arr.Length)
            {
                if (arr[i] == x)
                {
                    find = true;
                    foundIndex = i;
                    break;
                }
                i++;
            }

            if(find)
            {
                Console.Write($"Found value {x} at : {foundIndex}");
            }
            else
            {
                Console.Write("Not found");
            }

            Console.ReadLine();
        }
        
            ----------------- Bubble Sort -----------------

        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 10, 9, 7, 2, 6 };
            int n = arr.Length;


            for(int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.Write("\n Sorted Array: ");
            foreach(int list in arr)
            {
                Console.Write($"{list} ");
            }
        }


              ----------------- Selection Sort -----------------


        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 10, 9, 7, 2, 6 };
            int n = arr.Length;

            for(int i = 0; i < n - 1; i++)
            {
                int si = i;
                for(int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[si])
                    {
                        si = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[si];
                arr[si] = temp;
            }

            foreach(int num in arr)
            {
                Console.Write($"{num} ");
            }

             ----------------- Insertion Sort -----------------
        */

        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 5, 2, 3 };
            int n = arr.Length;

            for(int i = 1; i < n; i++)
            {
                int curr = arr[i];
                int prev = i - 1;

                while(prev >= 0 && arr[prev] > curr)
                {
                    arr[prev + 1] = arr[prev];
                    prev--;
                }

                arr[prev + 1] = curr;
            }

            foreach(int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
    }

}
