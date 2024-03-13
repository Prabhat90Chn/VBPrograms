using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Collections
{
    internal class SortedDictionaryClass
    {
        public static void sDictionaryMain()
        {
            SortedDictionary<int, String> sdic = new SortedDictionary<int, String>();

            sdic.Add(004, "Ask.com");
            sdic.Add(003, "Yahoo");
            sdic.Add(001, "Google");
            sdic.Add(005, "AOL.com");
            sdic.Add(002, "Bing");
            Console.WriteLine("Top Search Engines:");
            // Accessing the key/value pair of the 
            // SortedDictionary Using foreach loop
            foreach (KeyValuePair<int, string> pair in sdic)
            {
                Console.WriteLine("Rank: {0} and Name: {1}",
                                      pair.Key, pair.Value);
            }
            if (sdic.ContainsKey(004) == true)
            {
                Console.WriteLine("Key Found..");
            }
            else
            {
                Console.WriteLine("Key Not Found..");
            }

            // Using ContainsValue(TValue) method
            if (sdic.ContainsValue("Baidu") == true)
            {
                Console.WriteLine("Value Found..");
            }

            else
            {
                Console.WriteLine("Value Not Found..");
            }

            String v1 = sdic[002];
            // String v2 = sdic[006]; thos will thrown 'KEYNOTFOUND' exception

            Console.WriteLine($"002 value : {v1}");   
            //Console.WriteLine($"006 value: {v2}"); 

            // Access elements by key using TryGetValue() method
            string count;
            if (sdic.TryGetValue(001, out count))
            {
                Console.WriteLine($"001 value: {count}"); 
            }
            else
            {
                Console.WriteLine("001 not found in the dictionary");
            }
            
            string count1;
            if (sdic.TryGetValue(006, out count1))
            {
                Console.WriteLine($"006 value: {count1}");
            }
            else
            {
                Console.WriteLine("006 not found in the dictionary");
            }

            // Accessing an element with a non-existent key will throw a KeyNotFoundException
            // To avoid this, you can use the TryGetValue
            Console.ReadLine();
        }

    }
}
