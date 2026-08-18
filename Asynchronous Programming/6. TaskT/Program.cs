using System;
using System.Threading;
using System.Threading.Tasks;


namespace _6.TaskT
{
    class Program
    {
        static async Task PrintMessage()
        {
            await Task.Delay(2000);
            Console.WriteLine(" Hello form Task!");
        }

        static async Task<int> GetNumber()
        {
            await Task.Delay(2000);
            return 100;
        }

        static async Task<string> GetString()
        {
            await Task.Delay(2000);
            return "Blade";
        }

        static async Task<Student> GetStudent()
        {
            await Task.Delay(2000);

            return new Student
            {
                Id = 1,
                Name = "Crystal",
                Marks = 69
            };
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("|======= Task<T> ======= | \n");

            Console.WriteLine(" ===== Task ===== ");

            await PrintMessage();

            Console.WriteLine();

           // ========================================

            Console.WriteLine(" ===== Task<int> =====");

            int num = await GetNumber();

            Console.WriteLine($" Number : {num}");

            Console.WriteLine();

            // ========================================

            Console.WriteLine(" ===== Task<string> =====");

            string name = await GetString();

            Console.WriteLine($" Name : {name}");

            Console.WriteLine();

            // ========================================

            Console.WriteLine("===== Task<Student> =====");

            Student stud = await GetStudent();

            Console.WriteLine($"Id : {stud.Id}");
            Console.WriteLine($"Name : {stud.Name}");
            Console.WriteLine($"Marks : {stud.Marks}");

            Console.ReadLine();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}