using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class ListCollection
    {
        public static void ListMain()
        {
            // Creating List
            
            /*Here we can add null in List*/
            List<Object> nList = new List<Object>();
            nList.Add(null);
            
            
            List<int> list = new List<int>();
            List<int> listCap = new List<int>(6);
            List<List<int>> list2= new List<List<int>>();

            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            

            listCap.Add(11);
            listCap.Add(12);
            listCap.Add(13);
            listCap.Add(14);
            listCap.Add(15);
            listCap.Add(16);

            list2.Add(list);
            list2.Add(listCap);

            /*Accessing Elements
              (1) Method */
            foreach(int i in list)
            {
                Console.WriteLine("First list elements are = "+i);
            }

            // (2) Method
            listCap.ForEach(a => Console.WriteLine("Second list elemenmts are = " + a));

            //(3) Method
            for(int i = 0; i < list2.Count; i++) 
            {
                Console.WriteLine(i + 1 + " List in list2 is = ");
               foreach( int l in list2[i]) 
                { 
                    Console.WriteLine(l+" ");
                }
            }

            //DELETING ELEMENTS OF LIST

            // Initial count
            Console.WriteLine("Initial count:{0}", list.Count);

            // After using Remove() method
            list.Remove(1);
            Console.WriteLine("2nd count:{0}", list.Count);

            // After using RemoveAt() method
            list.RemoveAt(4);
            Console.WriteLine("3rd count:{0}", list.Count);

            // After using RemoveRange() method
            list.RemoveRange(0, 2);
            Console.WriteLine("4th count:{0}", list.Count);

            // After using Clear() method
            list.Clear();
            Console.WriteLine("5th count:{0}", list.Count);
        }
    }
}
