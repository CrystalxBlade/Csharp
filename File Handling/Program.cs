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
            Console.WriteLine($"Reading inside text: {date}");

            //======================================================
            // 5. Append Text
            //======================================================

            File.AppendAllText(file, "\n Second Line");
            Console.WriteLine("Text Appended");

            //======================================================
            // 6. Copy File
            //======================================================

            string copy = Path.Combine(folderPath, "Student_Copy.txt");
            File.Copy(file, copy, true);
            Console.WriteLine("File Copied");


            //======================================================
            // 7. Check File Exists
            //======================================================

            if (File.Exists(copy))
            {
                Console.WriteLine("File Exists");
            }

            /* -----------------------------------------------------

            //======================================================
            // 8. Move File
            //======================================================

            
            string moved = Path.Combine(folderPath, "MovedStudent.txt");
            File.Move(copy, moved);
            Console.WriteLine("File Moved");
            

            //======================================================
            // 9. Delete File
            //======================================================

            -----------------------------------------------------  */

            File.Delete(copy);
            Console.WriteLine("File Deleted");

            if (File.Exists(copy))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("Not Exists");

            Console.ReadLine();
        }
    }
}
