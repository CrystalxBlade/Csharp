using System;
using System.Collections.Generic;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable stud = new Hashtable();

            stud.Add(101, "Blade");
            stud.Add(105, "Knight");
            stud.Add(107, "Hornet");
            stud.Add("Email", "hornet@gmail.com");
            stud.Add("Coins", 2500);

            foreach(DictionaryEntry students in stud)
            {
                Console.WriteLine($"{students.Key} : {students.Value}");
            }

            Console.WriteLine($"\nContains key 105: {stud.ContainsKey(105)}");

            stud.Remove(105);

            Console.WriteLine("\nAfter Removing:");

            foreach (DictionaryEntry students in stud)
            {
                Console.WriteLine($"{students.Key} : {students.Value}");
            }

            Console.ReadLine();
        }
    }
}
