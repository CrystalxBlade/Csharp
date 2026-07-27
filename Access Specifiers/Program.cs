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

        public void ShowPrivate()
        {
            Private();
        }
    }
     
    class Two : Program
    {
        static void Main(string[] args)
        {
            Two obj = new Two();

            obj.Protected();    // Protected method can be accessed because Two inherits Program

            obj.Internal();     // Internal method can be accessed because it's in the same assembly

            obj.ShowPrivate();  // Private method cannot be accessed directly


            Console.ReadLine();
        }
    }

}
