using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class BabyDog:Dog
    {
        public override void Eat() 
        {

        //sealed int i = 1; Local variable can't be sealed
        
            Console.WriteLine("eating biscuits...");
            // Cannot override this as run method is sealed in Dog() class
        //public override void Run() { Console.WriteLine("running slowly..."); 
        
     }
    }
}
