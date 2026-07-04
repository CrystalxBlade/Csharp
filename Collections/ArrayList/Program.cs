using System;
using System.Collections.Generic;
using System.Collections;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(100);
            Console.WriteLine(al.Capacity); // allocating rooms for 4 items

            al.Add(200); al.Add(300); al.Add(400); // 4 rooms filled 
            Console.WriteLine(al.Capacity);

            al.Add(200);                    // capacity increased form 4 to 8 
            Console.WriteLine(al.Capacity);

            foreach(object obj in al)
            {
                Console.Write($"- {obj} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            al.Insert(3, 150);
            foreach(object obj in al)
            {
                Console.Write($"- {obj} ");
            }

            Console.ReadLine();
        }
    }
}
