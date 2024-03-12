using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class WhileLoop
    {
        //WHILE LOOP
        public static void WhileLoopMain(){
            int i = 1;
            while ((i <= 3)){
                Console.WriteLine("Value of i is = "+ i);
                i++;
            }
        }
        public static void NestedWhileLoopMain() {
            int i = 1;
            while((i <= 3))
            {
                int j = 1;
                while(j <= 3)
                {
                    Console.WriteLine("Value of i and j is = " + i + " " + j);
                }
            }
        }
        public static void InfiniteWhileLoopMain() {
            while (true)
            {
                Console.WriteLine("Infinite While Loop... To exit press Ctrl+ C");
            }
        }
    }
}
