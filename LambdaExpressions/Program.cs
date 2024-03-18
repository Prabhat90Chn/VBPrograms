using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LambdaExpressions.Program.LambdaExpresionDisplay();
        }
        static void LambdaExpresionDisplay()
        {
            List<int> value = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };
            foreach (int v in value)
            {
                Console.WriteLine(" Values are = {0}", v);
            }
            //
            var square = value.Select(x => x * x);
            IEnumerator<int> i = square.GetEnumerator();
            while (i.MoveNext())
            {
                Console.WriteLine("Sqaure value is {0}",i.Current);
            }
            //
            List<int> divBy3=value.FindAll(x=>(x%3)==0);
            IEnumerator<int> e= divBy3.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine("Div by 3 are = " + e.Current);
            }

            StudentLambda s = new StudentLambda();
            s.Display();

        }
        
       
    }
}
