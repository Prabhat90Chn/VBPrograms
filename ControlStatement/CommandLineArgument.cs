using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class CommandLineArgument
    {
        public static void ArgsMain(string[] args)
        {
            Console.WriteLine("total no of arguments");
            Console.WriteLine("Supplied arguments are :");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
