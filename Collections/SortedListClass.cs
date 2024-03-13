using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class SortedListClass
    {
        public static void MainSorted() {
            
            // Creating an SortedList 
            SortedList<int, String> sList = new SortedList<int, String>();

            SortedList<Object, Object> l = new SortedList<Object, Object>();
            l.Add(1, 1);
            l.Add(2, null);
           // l.Add(null, null); //$exception	{System.ArgumentNullException: Value cannot be null. (Parameter 'key')

            // Adding elements to SortedList 
            sList.Add(1, "one");
            sList.Add(2, "two");
            sList.Add(3, "three");
            sList.Add(4, "four");
            sList.Add(5, "five");

            Console.WriteLine("Capacity = "+sList.Capacity);
            Console.WriteLine("Count = "+sList.Count);
            Console.WriteLine("Is 'One' value present = "+sList.ContainsValue("one"));
            Console.WriteLine("Is 'Six' value present = "+sList.ContainsValue("six"));

            // The key/value pairs of the SortedList is accessed using three different ways:
            // 1) For Loop

            for(int i = 0; i < sList.Count; i++)
            {
                Console.WriteLine(sList.Keys[i] +" "+ sList.Values[i]);
            }

            // 2)  Using Index: get the value on the specific index
            string x = sList[1];
            Console.WriteLine("Value at 1 index = "+x);

            // 3) foreach loop
            foreach( KeyValuePair<int, String> pair in sList )
            {
                Console.WriteLine(pair.Key+" "+ pair.Value);
            }
            // Remove Element
            //sList.Remove(1);
            //sList.RemoveAt(0);
            Console.WriteLine("Sorted list after removal");
            Console.WriteLine("****************");
            int inxed= sList.IndexOfValue("four");
            Console.WriteLine(inxed);
            Console.WriteLine("Inxed value = " + sList[inxed]);

            foreach (KeyValuePair<int, String> pair in sList)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
                
            }

        }
    }
}
