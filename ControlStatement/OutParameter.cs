using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class OutParameter
    {
        public void Show(out int val1, out int val2)
        {
            int v = 5;
            val1 = v;
            val2  = v;
            val1 = val1 * val1;
            val2 = val1 * val2;
            Console.WriteLine("Value inside called CBR method = " + val1 + " " + val2);
        }

        public static void OutMain(/*String[] args*/)
        {
            int val1;// no need to initialize when using out
            int val2;
            OutParameter obj = new OutParameter();
            obj.Show(out val1, out val2);
            Console.WriteLine("Value after method call = " + val1 + " " + val2);
        }

}
}
