using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class SecondClass: BaseClass
    {
        public new int integerValue = 2;
        public  string stringValue = "secondBase";

        
        public override void Basemethod()
        {
            Console.WriteLine("SecondClass class method running");
            Console.WriteLine("SecondClass class integer value with new = " + integerValue);
            Console.WriteLine("SecondClass class string value = " + stringValue);
           


        }

        /* public virtual void Basemethod()
         {
             Console.WriteLine("Second class"+i);
         }*/
    }
}
