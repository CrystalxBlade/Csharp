using System;

namespace Generic_Class
{
    class Box<T>
    {
        public T Value { get; set; }

        public void Display()
        {
            Console.WriteLine(Value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> number = new Box<int>();
            number.Value = 100;
            number.Display();

            Box<string> name = new Box<string>();
            name.Value = "Blade";
            name.Display();

            Console.ReadLine();
        }
    }
}
