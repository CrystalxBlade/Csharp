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

            string fpath = @"D:\C# codes\File Handling\Files";

            Directory.CreateDirectory(fpath);

            Console.WriteLine("Directory Created");


            Console.ReadLine();
        }
    }
}
