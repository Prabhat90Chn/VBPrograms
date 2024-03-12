using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class DerivedOverriding:SecondOverride
    {
         public  override void Basemethod()
        {
            Console.WriteLine("Derived Class"+i);
          
        }
        public static void Display()
        {
            MethodOverriding obj1 = new MethodOverriding();
            obj1.Basemethod();
            SecondOverride obj2 = new SecondOverride();
            obj2.Basemethod();
            DerivedOverriding obj = new DerivedOverriding();    
            obj.Basemethod();
        }
    }
}
