using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class SecondClass:BaseClass
    {
        public int secondId = 2;
        public string secondStr = "second";

        public SecondClass()
        {
            Console.WriteLine("Second class Constructor running");
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second class Method called");
        }
    }
}
