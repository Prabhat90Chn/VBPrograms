using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    public static class StaticClass
    {
        public static float pi = 3.14f;

        static StaticClass()
        {
            Console.WriteLine("dEFAULT Constructor");
        }

        public static int Cube(int x)
        {
            return x * x * x;
        }
    }
}
