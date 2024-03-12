using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class DoWhileLoop
    {
        public static void DoWhileMethod()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Value of i is = " + i);
                i++;
            } while (i < 10);
        }

        public static void NestedDoWhileLoop()
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine("Value of i and j = " + i + " " + j);
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 3);
        }

        public static void InfiniteDoWhileLoop()
        {
            do
            {
                Console.WriteLine("Infinite DoWhile Loop...To break press Ctrl+C");
            } while (true);
        }
    }
}
