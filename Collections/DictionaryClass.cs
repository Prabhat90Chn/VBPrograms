using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class DictionaryClass
    {
        public static void DictionaryMain() 
        { 
          Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1,"one"); dictionary.Add(2, "two"); dictionary.Add(3, "three");
            dictionary.Add(4, "four"); dictionary.Add(5, "five"); dictionary.Add(6, "six");

            // To get count of key/value pairs in dictionary
            Console.WriteLine(dictionary.Count);

            // Displaying the key/value pairs in myDict
            Console.WriteLine("\nThe key/value pairs" +
                               " in dictionary are : ");

            foreach(KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                                  kvp.Key, kvp.Value);
            }

            // To get the keys alone, use the Keys property.
            Dictionary<int, string>.KeyCollection keyColl =
                                                  dictionary.Keys;
            foreach(int keys in keyColl )
            {
                Console.Write(keys+" ");
            }
            // To get the values alone, use the Values property.
            Dictionary<int, string>.ValueCollection valueColl =
                                                    dictionary.Values;

            foreach (string value in valueColl)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            // Using Index//It gives 'KEYNOTFOUND EXCEPTION' if key not found 
            Console.WriteLine("Value is:{0}", dictionary[1]);
            Console.WriteLine("Value is:{0}", dictionary[2]);

        }
    }
}
