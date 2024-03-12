using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal static class QueueClass
    {
        //Constructors
        /*Queue<int> q = new Queue<int> ();
        Queue<int> q1 = new Queue<int> (8);
        Queue<int> q2 = new Queue<int>(8,Single);
        Queue<int> q3 = new Queue<int>(q);
        // Add null
        Queue<Object> queue = new Queue<Object>();
        queue.Enqueue(null);*/
         
        public static void QueueMain()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); queue.Enqueue(2); queue.Enqueue(3); queue.Enqueue(4); queue.Enqueue(5); queue.Enqueue(6);
            foreach (int i in queue)
            {
                Console.Write(i+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("Total elements = "+ queue.Count);
            //peek()
            Console.WriteLine("First Element = "+ queue.Peek());
            Console.WriteLine("Total count after peek = "+queue.Count);
            //Dequeue()
            Console.WriteLine("Dequed element = "+queue.Dequeue());
            Console.WriteLine("Total elements after dequeue = "+queue.Count);
            foreach (int i in queue)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            //Conatins()
            Console.WriteLine("IS 7 present = "+ queue.Contains(7));
            //Clear()
            queue.Clear();
            Console.WriteLine("Count after clear = "+queue.Count);
        
        }
        

        

        

    }
}
