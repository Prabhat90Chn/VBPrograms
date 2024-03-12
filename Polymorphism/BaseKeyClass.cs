using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class BaseKeyClass
    {
        public string name = "Base Feild";
        public virtual void  BaseMethod()
        {
            Console.WriteLine(name);
        }
    }
}
