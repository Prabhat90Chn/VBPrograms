using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
   // sealed public class Animal // this class cannot be inherited
    public  class Animal
    {
        public virtual void Eat() { Console.WriteLine("eating..."); }
        public virtual void Run() { Console.WriteLine("running..."); }
    }
}
