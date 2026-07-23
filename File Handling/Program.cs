using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"DemoFolder";
            string filePath = Path.Combine(folderPath, "Student.txt");



            Console.WriteLine("===== Create Directory =====");
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Directory Created");

            Console.ReadLine();
        }
    }
}
