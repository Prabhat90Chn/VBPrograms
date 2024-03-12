using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class SortedSetClass
    {
        public static void SortedSetMain()
        {
            /*SortedSet<Object> obj = new SortedSet<Object>();
            obj.Add("1");
            obj.Add(null);
            obj.Add("2"); // have to give same type of values
            foreach (Object o in obj){
                Console.WriteLine(o +" "+obj.Count);
            }
            obj.Remove(null);
            Console.WriteLine("Count after remove =  " + obj.Count);*/

            SortedSet<int> obj = new SortedSet<int>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(4); 
            obj.Add(5);
            obj.Add(6);


            Console.WriteLine("Total number of elements " +
               "present in my_Set:{0}", obj.Count);

            // Remove element from SortedSet
            // Using Remove method
            obj.Remove(1);

            // Before using Remove method
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", obj.Count);

            // Remove all elements from SortedSet
            // Using Clear method
            obj.Clear();
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", obj.Count);
        }
    }
        
        
    }

