using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Square : AbstractShape
    {
        private int side;
        public Square(int side)
        {
            this.side = side;   
        }
        public override void area()
        {
            Console.Write("Area of Square: "+ side * side);
        }
    }
}
