using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class CallByValue
    {
        public void Show(int val)
        {
            val *= val;
            Console.WriteLine("Value inside method call = " + val);
        }
        public static void CBVMain(string[] args) {
            int val = 5;
            Console.WriteLine("Original Value = "+val);
            CallByValue obj = new CallByValue();
            obj.Show(val);
            Console.WriteLine("Value after call = " + val);
        }
    }
}