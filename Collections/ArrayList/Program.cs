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
            Console.WriteLine(al.Capacity);

            Console.ReadLine();
        }
    }
}
