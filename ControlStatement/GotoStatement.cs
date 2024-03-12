using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class GotoStatement
    {
        public static void GotoStatementMethod()
        {
        ineligible:
            Console.WriteLine("Not eligible for voting");

            Console.WriteLine("Enter age \n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("Eligible for voting");
            }
        }
    }
}
