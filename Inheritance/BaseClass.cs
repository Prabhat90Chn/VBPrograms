using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class BaseClass
    {
        public int baseId=1;
        public string baseStr = "base";
    
        public BaseClass() {
            Console.WriteLine("Base class Constructor running");
        }
    public void BaseMethod()
        {
            Console.WriteLine("Base class Method called");
        }
    }
 }
