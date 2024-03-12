using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class CallByReference
    {
        public void Show(ref int val1, ref int val2)
        {
            val1 = val1*val1;
            val2 = val2*val2;   
            Console.WriteLine("Value inside called CBR method = "+val1 +" "+ val2);
        }

        public static void CBRMain(/*String[] args*/)
        {
            int val1= 5; // We need to initalize these parameters if we want to pass with ref keyword in show method
            int val2= 6;
            //Console.WriteLine("Original value = "+val1 +" "+val2);
            CallByReference obj = new CallByReference();
            obj.Show( ref val1, ref val2 );
            Console.WriteLine("Value after method call = " + val1 + " " + val2);
        }
    }
}
