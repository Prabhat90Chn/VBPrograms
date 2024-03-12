using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Polymorphism
{
    internal class MethodOverloading
    {
        public void Display()
        {
            Console.WriteLine("1st");
        }
        public void Display(String str)
        {
            Console.WriteLine(str);
        }
        public void Display(int i)
        {
            Console.WriteLine(i);
        }

        public static void MOverloadingMain()
        {
            MethodOverloading obj = new MethodOverloading();
            obj.Display();
            obj.Display("abc");
            obj.Display(1);
        }
    }
}
