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

            Console.WriteLine();

            //======================================================
            // 2. Create File
            //======================================================

            string file = Path.Combine(folderPath, "Student.txt");

            File.Create(file).Close();

            Console.WriteLine("File Created");

            Console.WriteLine();

            //======================================================
            // 3. Write Text
            //======================================================

            File.WriteAllText(file, "Hello form C#");
            Console.WriteLine("Text Written");

            Console.WriteLine();
            //======================================================
            // 4. Read Text
            //======================================================

            string date = File.ReadAllText(file);
            Console.WriteLine($"Reading inside text: {date}");

            Console.WriteLine();
            //======================================================
            // 5. Append Text
            //======================================================

            File.AppendAllText(file, "\n Second Line");
            Console.WriteLine("Text Appended");

            Console.WriteLine();
            //======================================================
            // 6. Copy File
            //======================================================

            string copy = Path.Combine(folderPath, "Student_Copy.txt");
            File.Copy(file, copy, true);
            Console.WriteLine("File Copied");

            Console.WriteLine();
            //======================================================
            // 8. Check File Exists
            //======================================================

            if (File.Exists(copy))
            {
                Console.WriteLine("File Exists");
            }

            Console.WriteLine();
            /* -----------------------------------------------------

            //======================================================
            // 7. Move File
            //======================================================

            
            string moved = Path.Combine(folderPath, "MovedStudent.txt");
            File.Move(copy, moved);
            Console.WriteLine("File Moved");
            

            //======================================================
            // 9. Delete File
            //======================================================


            File.Delete(moved);
            Console.WriteLine("File Deleted");

            -----------------------------------------------------  */

            //======================================================
            // 10. Get File Information
            //======================================================


            Console.WriteLine($"File name: {Path.GetFileName(file)}");
            Console.WriteLine($"Extension: {Path.GetExtension(file)}");
            Console.WriteLine($"Directory: {Path.GetDirectoryName(file)}");
            Console.WriteLine($"Without Extension: {Path.GetFileNameWithoutExtension(file)}");

            Console.ReadLine();
        }
    }
}
