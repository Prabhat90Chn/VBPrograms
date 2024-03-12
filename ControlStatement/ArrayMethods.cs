using System;
using System.Collections.Generic;
using System.Text;

namespace ControlStatement
{
    internal class ArrayMethods
    {
        public static void ArrayFunctionMain()
        {
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            int[] arr2 = new int[6]; //EMPTY ARRAY
                Console.WriteLine(arr.Length);
            Array.Sort(arr); //SORTING ARRAY
            PrintArray(arr);
            Console.WriteLine("25 in at index = " + Array.IndexOf(arr, 25));
            Array.Copy(arr, arr2, arr.Length);
            PrintArray(arr2);
            Array.Reverse(arr);
            PrintArray(arr);
        }
        static void PrintArray(int[] arr)
        {
            foreach(Object obj in arr)
            {
                Console.WriteLine(obj+" ");
            }
        }
    }
}
