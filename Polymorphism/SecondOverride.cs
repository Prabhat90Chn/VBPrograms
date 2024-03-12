using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class SecondOverride: MethodOverriding
    {
        /*public override void Basemethod()
        {
            Console.WriteLine("Second class");
        }*/

        public virtual void Basemethod()
        {
            Console.WriteLine("Second class"+i);
        }
    }
}
