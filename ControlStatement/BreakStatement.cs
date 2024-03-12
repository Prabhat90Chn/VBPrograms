using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class BreakStatement
    {
        public static void BreakStatementMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("Value id i is = " + i);
            }
        }

        public static void InnerBreakStatementMethod() {
        for (int i = 0; i<=3; i++) {
            for(int j = 0; j <= 3; j++)
                {
                    if(i==2 && j == 2)
                    {
                        break;
                    }
                    Console.WriteLine("Value id i and j is = " + i + " " + j);
                }
            }
        }
    }
}