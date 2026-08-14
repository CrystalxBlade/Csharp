using System;
using System.IO;


namespace DUCAT_File_Handling
{
    class Program
    {
        public void ReadFile()
        {
            Console.WriteLine("Enter The File Location/Name");

            string file = "D:\\C# codes\\File Handling\\DUCAT\\Demo " +Console.ReadLine()+".txt";

            //Console.WriteLine(file);

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine(); 
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ReadFile();

            Console.ReadLine();
        }
    }
}
