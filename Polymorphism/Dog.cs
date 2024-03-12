using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Dog:Animal
    {
        public override void Eat() { Console.WriteLine("eating bread..."); }
        public sealed override void Run()
        {
            Console.WriteLine("running very fast...");
        }
    }
}
