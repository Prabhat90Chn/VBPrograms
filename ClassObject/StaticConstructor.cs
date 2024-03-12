using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassObject
{
    internal class StaticConstructor
    {
        public int id;
        public static float roI;

        static StaticConstructor() {
            Console.WriteLine("Static constructor running");
            roI = 9.5f;
        }
        public StaticConstructor(int id)
        {
            Console.WriteLine(roI);
            Console.WriteLine("Normal constructor running");
            this.id = id;
            roI = 3.5f;
        }
         public void Display()
        {
            Console.WriteLine(roI);
        }
    }
}
