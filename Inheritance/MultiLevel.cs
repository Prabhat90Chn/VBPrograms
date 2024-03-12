using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class MultiLevel:SecondClass
    {
        public MultiLevel() {
            Console.WriteLine("MultiLevel Constructor");
        }
        public static void Multimain()
        {
            MultiLevel obj = new MultiLevel();
            Console.WriteLine("Base class = " + obj.id);
            obj.BaseMethod();
            Console.WriteLine("Second class = " + obj.name);
            obj.SecondMethod();
        }
    }
}
