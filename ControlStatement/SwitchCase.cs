using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class SwitchCase
    {
        public static void SwitchMain()
        {
            Console.WriteLine("Enter the 10 multiple");
            int num=Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 10:
                    Console.WriteLine("10 is entered");
                    break;
                case 20:
                    Console.WriteLine("20 is entered");
                    break;
                 default:
                    Console.WriteLine("10 or 20 is not entered");   
                    break;
            }
        }
    }
}
