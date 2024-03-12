using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    internal class StaticFeilds
    {
       public  int id;
       public String name;
       public static float rOI = 8.8f;

        public StaticFeilds(int id, String name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Original value of rOI = " + rOI);
            Display();
        } 
        public void Display()
        {
            StaticFeilds.rOI = 5.5f;
            Console.WriteLine(id+" "+name+" "+rOI);
        }
    }
}
