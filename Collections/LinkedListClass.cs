using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Collections
{
    internal class LinkedListClass
    {
        public static void LinkedListMain()
        {
            /*
              //Constructors (3)
            LinkedList<int > ll1 = new LinkedList<int> ();
            LinkedList<int> ll2= new LinkedList<int> (IEnumerator);
            LinkedList<int> ll3= new LinkedList<int> (SerializationInfo,StreamingContext);
            string [] students = {"Henry","David","Tom"};
            LinkedList<string> list = new LinkedList<string>(students);
            */
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(0);
            ll.AddLast(1);
            ll.AddLast(3);
            //Add node after given node
            var newNode = ll.Find(3);
            ll.AddAfter(newNode, 4);
            ll.AddBefore(newNode, 2);
            ll.AddLast(5);
            Display();
            //Remove()
            ll.RemoveFirst();
            Console.WriteLine("After RemoveFirst()");
            Display();
            Console.WriteLine();
            ll.RemoveLast();
            Console.WriteLine("After RemoveLast()");
            Display();
            ll.Remove(1);
            Console.WriteLine("After Remove(1)");
            Display();
            var nNode = ll.Find(2);
            ll.Remove(nNode);
            Console.WriteLine("After Remove(nNode)");
            Display();
            ll.Clear();
            Console.WriteLine("After clear, size of Linked List is = "+ll.Count);

            void Display()
            {
                {
                    foreach (var item in ll)
                    {
                        Console.Write(item + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
