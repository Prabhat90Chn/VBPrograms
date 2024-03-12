using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class SecondClass:BaseClass
    {
        public String name="abc";

        public SecondClass()
        {
            Console.WriteLine("Second class Constructor");
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second class Method");
        }
    }
}
