using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast
{
    public delegate void GetDelegate(double x, double y);

    class Program
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($" Area: {Width * Height}");
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($" Perimeter: { 2 * (Width + Height)}");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            GetDelegate obj = p.GetArea;

            obj += p.GetPerimeter;

            obj.Invoke(24.56, 49.12);

            Console.WriteLine();

            obj.Invoke(48.12, 64.81);

            Console.ReadLine();
        }
    }
}
