using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine(new Program().GetHashCode());
            Console.WriteLine(new Program().GetHashCode());


            Console.ReadKey();
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        //Generate a function

    }
}
