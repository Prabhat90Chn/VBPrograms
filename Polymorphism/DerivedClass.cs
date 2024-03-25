using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class DerivedClass:SecondClass
    {
        public  int integerValue = 3;
        public new string stringValue = "DerivedOverriding";
        public  override void Basemethod()
        {
            Console.WriteLine("DerivedClass class method running");
            Console.WriteLine("DerivedClass class integer value = " + integerValue);
            Console.WriteLine("DerivedClass class string value with new = " + stringValue);
            

        }
        public static void Display()
        {
            BaseClass baseObject = new DerivedClass();
            baseObject.Basemethod();
            Console.WriteLine(baseObject.GetType().Name+" = "+baseObject.integerValue+"  "+baseObject.stringValue);
            Console.WriteLine();
            SecondClass secondObject = new DerivedClass();
            secondObject.Basemethod();
            Console.WriteLine(secondObject.GetType().Name + " = " + secondObject.integerValue + "  " + secondObject.stringValue);
            Console.WriteLine();
            DerivedClass thirdObject = new DerivedClass();    
            thirdObject.Basemethod();
            Console.WriteLine(thirdObject.GetType().Name + " = " + thirdObject.integerValue + "  " + thirdObject.stringValue);
            Console.WriteLine();

        }
       

    }
}
