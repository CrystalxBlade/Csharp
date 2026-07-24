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

            //======================================================
            // 1. Create Directory
            //======================================================

            string folderPath = @"D:\C# codes\File Handling\Files\Directory";

            Directory.CreateDirectory(folderPath);

            Console.WriteLine("Directory Created");

            //======================================================
            // 2. Create File
            //======================================================

            string file = Path.Combine(folderPath, "Student.txt");

            File.Create(file).Close();

            Console.WriteLine("File Created");

            Console.ReadLine();
        }
    }
}
