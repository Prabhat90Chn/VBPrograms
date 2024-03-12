using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassObject
{
    public struct Emp{
        //public int ID = 5; Setting value here at feild is not allowed. To set value use 
        //                   parameterized constructor.
        public int id;
        public string name;

        /*public Emp()
        {
            This default constructor is not allowed to be modified in Struct
        }*/

        static Emp()
        {
            // We can create static constructor for no parameter
            Console.WriteLine("Inside static no parameter constructor");
        }
        public Emp(int id, String name)
        {
            Console.WriteLine("Inside parameterized constrctor of Struct");
            this.id = id;
            this.name = name;
            Console.WriteLine(id + " " + name);
        }
    }
    internal class StructClass
    {
        public void Display()
        {
            Console.WriteLine("Inside class");
            Emp e = new Emp();
            e.id = 1;
            e.name = "abc";
            Console.WriteLine("Id is " + e.id + " Name is = " + e.name);

            Emp e1 = new Emp(2, "xyz");
            Console.WriteLine(" New Id  is " + e1.id + " New Name is = " + e1.name);
        }
    }
}
