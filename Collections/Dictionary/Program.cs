using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(6, "Blade");
            students.Add(8, "Hornet");
            students.Add(4, "Knight");

            foreach(var stud in students)
            {
                Console.WriteLine($"{stud.Key} : {stud.Value}");
            }

            Console.WriteLine($"\nConstains key 8 : {students.ContainsKey(8)}");

            students.Remove(8);

            Console.WriteLine("\nAfter removing: \n");

            foreach(var stud in students)
            {
                Console.WriteLine($"{stud.Key} : {stud.Value}");
            }
            Console.ReadLine();
        }
    }
}
