using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class ParamParameter
    {
        public static void ParamMain()
        {
            ParamParameter obj = new ParamParameter();
            obj.Show("a", 1, 2, 3, 4, 5 );
            obj.Show1("b", "strobj", 101, 20.5, 'A',25.6f);
        }

        public void Show(String str,params int[] arr )
        {
            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ str);
            }
        }
        public void Show1(String str, params object[] obj)
        {
            for(int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(obj[i] + " " + str);
            }
        }
    }
}
