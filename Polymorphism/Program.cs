using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Polymorphism.MethodOverloading.MOverloadingMain();
            Polymorphism.DerivedOverriding.Display();
            SecondBase obj = new SecondBase();
            obj.BaseMethod();*/
            Square obj = new Square(3);
            obj.area();
        }
    }
}
