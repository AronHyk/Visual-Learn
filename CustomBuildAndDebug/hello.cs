using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBuild
{
    public class Build
    {
        static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine(args[0]);
            }

            Console.ReadKey();
        }
    }
}