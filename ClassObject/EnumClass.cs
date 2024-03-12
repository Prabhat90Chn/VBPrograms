using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    internal class EnumClass
    {
        public enum Season { Winter, Spring, Summer, Fall}
        public enum Names { a=10,b,c,d,e}// here insted of 0, index will start from 10
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void EnumMain()
        {
            Console.WriteLine(Season.Winter);// return string value
            int x = (int)Season.Winter;// return int vlaue of constant index
            int y = (int)Season.Summer;
            Console.WriteLine("Winter index is = "+x);
            Console.WriteLine("Summer index is = " + y);

            int z = (int)Names.a;
            int z1= (int)Names.e;
            Console.WriteLine("Changed index of 'a' is = " + z);
            Console.WriteLine("Changed index of 'e' is = " + z1);

            // GetNames return String[] (type) type of  values
            foreach( String s in Enum.GetNames(typeof(Days)))
            {
                //Console.WriteLine($"{s}");
                Console.WriteLine(s);
            }

            Console.WriteLine("******************");

            //GetValues return Array (type) values of type given Enum
            foreach (Days s in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(s);
            }

        }
    }
}
