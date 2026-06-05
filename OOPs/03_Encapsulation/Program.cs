using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation
{
    class Program
    {
        private int atmPin;

        public int getValue()
        {
            return atmPin;
        }

        public void setValue(int pin)
        {
            atmPin = pin;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.atmPin = 1234;
            p.getValue();
        }
    }
}
