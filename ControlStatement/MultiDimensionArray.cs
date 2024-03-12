using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class MultiDimensionArray
    {
        public static  void MultiDimArrMain()
        {
            int[,] arr21 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] arr22 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] arr23 = { { 1, 2 }, { 3, 4 } };
            int[,] arr31 = new int[3, 3] { { 1, 2, 3 }, { 4,5,6 }, {7,8,9 } };
            int[,] arr32 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr33 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i = 0; i < 2; i++) 
            {
              for(int j = 0; j < 2; j++) 
                {
                    Console.Write(arr21[i,j]);
                }
              Console.WriteLine();
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                   Console.Write(arr31[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(" 2 D Array length = " + arr21.Length);
            Console.WriteLine(" 3 D Array length = " + arr31.Length);


        }
    }
}
