using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class BasicArray
    {
        public static void ArrayMain()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr3 = { 10, 11, 12, 13, 14 };
            arr1[0] = 20;
            arr1[1] = 30;
            arr1[2] = 40;
            arr1[4] = 50;

            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
