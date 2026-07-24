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

            //======================================================
            // 3. Write Text
            //======================================================

            File.WriteAllText(file, "Hello form C#");
            Console.WriteLine("Text Written");

            //======================================================
            // 4. Read Text
            //======================================================

            string date = File.ReadAllText(file);
            Console.WriteLine($"Here is the text: {date}");

            Console.ReadLine();
        }
    }
}
