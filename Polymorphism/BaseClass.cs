using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class BaseClass
    {
        public int integerValue = 1;
        public string stringValue = "base";
        
        public virtual void Basemethod()
        {
            Console.WriteLine("Base class method running");   
            Console.WriteLine("Base class integer value = "+integerValue);
            Console.WriteLine("Base class string value = "+stringValue);
            
        }
    }
}
