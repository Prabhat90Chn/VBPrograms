using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Collections
{
    internal class StackClass
    {
        public static void StackMain() 
        {
               
            Stack<Object> st = new Stack<Object> ();
            st.Push(1);
            st.Push("2");
            Console.WriteLine("Total elements with null = " + st.Count);


            /* 3 Constructor for creating stack
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2= new Stack<int>(5);
            Stack stack3 = new Stack(IEnumerable);*/
            // Can store null
            Stack<Object> s = new Stack<object> ();
            s.Push (null);
            
            Stack<int>  stack = new Stack<int> ();
            stack.Push (1);stack.Push (2);stack.Push (3);stack.Push(4);
            stack.Push(5); stack.Push(6); stack.Push(7); stack.Push(8);
            Console.WriteLine("Total elements = " + stack.Count);

            // Peek method return top object without deleting it from stack
            Console.WriteLine(stack.Peek());
            Console.WriteLine("Total elements after peek = " + stack.Count);
            // Pop method return top object and delete it from object
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Total elements after pop = "+stack.Count);

            //Check method check if element is present
            Console.WriteLine("Is 7 present = " + stack.Contains(7));

            // Clear method  will empty the stack
            stack.Clear ();
            Console.WriteLine("Total elements after clear = "+stack.Count);
        }
    }
}
