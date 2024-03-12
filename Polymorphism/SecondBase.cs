using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class SecondBase:BaseKeyClass
    {
        public string name = "Second class feild";

        public override void BaseMethod()
        {
            base.BaseMethod();
            Console.WriteLine(base.name);
            Console.WriteLine(name);
        }
    }
}
