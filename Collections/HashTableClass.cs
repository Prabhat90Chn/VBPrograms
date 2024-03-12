using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class HashTableClass
    {
        public static void HashtableMain()
        {
            // create and initialize Hash table
            // using Add() method
            Hashtable g = new Hashtable();
            g.Add(1, "welcome");
            g.Add(2, "to");
            g.Add(3, "tutorials");
            g.Add(4, "of");
            g.Add(5, "C#");

            ICollection key = g.Keys;

            // Print Hash table
            Console.WriteLine("Hashtable:");
            Console.WriteLine();
            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + g[val]);
            }

            Hashtable has1 = new Hashtable();
            has1.Add("1", "Welcome");
            has1.Add("2", "to");
            has1.Add("3", "geeks");
            has1.Add("4", "for");
            has1.Add("5", "geeks");

            // Creating a synchronized packing
            // around the Hashtable
            Hashtable has2 = Hashtable.Synchronized(has1);

            // print the status of both Hashtables
            Console.WriteLine("has1 Hashtable is {0}.",
                 has1.IsSynchronized ? "synchronized" :
                                   "not synchronized");

            Console.WriteLine("has2 Hashtable is {0}.",
                 has2.IsSynchronized ? "synchronized" :
                                   "not synchronized");

            // --------- Using Count Property

            Console.WriteLine("Total Number of Elements in has1: "
                                                    + has1.Count);
            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + g[val]);
            }

            Console.WriteLine();

            // --------- Remove() Method ----------'

            // Remove element 4
            // using Remove() method
            g.Remove("4");

            // printing updated Hash table
            Console.WriteLine("Hashtable after removing element 4:");

            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + g[val]);
            }
        }
    }
}
