using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers
{
    public class Program
    {
        private void Private()
        {
            Console.WriteLine("Private Method");
        }

        protected void Protected()
        {
            Console.WriteLine("Protected Method");
        }

        internal void Internal()
        {
            Console.WriteLine("Internal Method");
        }
        protected internal ProtectedInternal()
        {
            Console.WriteLine("Protected Internal Method");
        }
    }
}
