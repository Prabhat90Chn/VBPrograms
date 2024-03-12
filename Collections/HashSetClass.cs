using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class HashSetClass
    {
        public static void HashMain()
        {
            /*We CAN ADD NULL IN HASHTABLE
            HashSet<Object> hSet = new HashSet<Object>();
            hSet.Add(1);
            hSet.Add(null);
            hSet.Add("ABC");
            foreach (Object obj in hSet)
            {
                Console.WriteLine("Object in = "+obj);
            }*/

            HashSet<string> hset = new HashSet<string>();
            hset.Add("C");
            hset.Add("C++");
            hset.Add("C#");
            hset.Add("Java");
            hset.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            // Accessing elements of HashSet
            // Using foreach loop
            foreach (var val in hset)
            {
                Console.WriteLine(val);
            }
            // Remove elements
            hset.Remove("Ruby");
            hset.Clear();

            //Set Operations

            // (1) UnionWith
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            // Using UnionWith method
            myhash1.UnionWith(myhash2);
            foreach (var ele in myhash1)
            {
                Console.WriteLine("UnionWith operation = "+ele);
            }

            //  (2) - IntersectWith
            HashSet<string> myhash11 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash11.Add("C");
            myhash11.Add("C++");
            myhash11.Add("C#");
            myhash11.Add("Java");
            myhash11.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash21 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash21.Add("PHP");
            myhash21.Add("C++");
            myhash21.Add("Perl");
            myhash21.Add("Java");

            // Using IntersectWith method
            myhash11.IntersectWith(myhash21);
            foreach (var ele in myhash11)
            {
                Console.WriteLine(ele);
            }

            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhash14 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash24 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            // Using ExceptWith method
            myhash14.ExceptWith(myhash24);
            foreach (var ele in myhash14)
            {
                Console.WriteLine(ele);
            }
        }
    }
}