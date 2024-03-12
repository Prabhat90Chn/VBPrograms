using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class ArrayToFunction
    {
        public static void ArrayFunctionMain()
        {
            int[] arr = new int[] { 25, 10, 20, 15, 40, 50 };
            ArrayToFunction obj = new ArrayToFunction();
            obj.ArrayMin(arr);
            obj.ArrayMax(arr);
        }

        public void ArrayMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum element of array is = " + min);
        }

        public void ArrayMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum element of array is = " + max);
        }
    }
}
