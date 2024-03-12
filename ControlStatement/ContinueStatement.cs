using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class ContinueStatement
    {
        public static void ContinueStatementMethod()
        {
            for (int i = 0; i < 10; i++) { 
            if(i == 5)
                {
                    continue;
                }
                Console.WriteLine("Value id i is = " + i);
            }
        }

        public static void InnerContinueStatementMethod()
        {
            for(int i = 0; i <=10 ; i++) 
            {
             for(int j = 0; j <=10 ; j++)
                {
                    if(i==5 && j == 5)
                    {
                        continue;
                    }
                    Console.WriteLine("Value id i and j is = "+i+" "+j);
                }
            }
        }
    }
}
