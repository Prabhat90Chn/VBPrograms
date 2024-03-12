using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class MethodOverriding
    {
        public int i = 1;
        public virtual void Basemethod()
        {
            Console.WriteLine("Base method"+ i);
        }
    }
}
