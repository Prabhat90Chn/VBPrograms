using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class MultiLevel : SecondClass
    {

        public int multiId = 3;
        public string multiStr = "multi";
        public MultiLevel()
        {
            Console.WriteLine("MultiLevel Constructor running");
        }
        public static void Multimain()
        {
            MultiLevel obj = new MultiLevel();
            Console.WriteLine("----MultiLevel obj = new MultiLevel()----- ");
            Console.WriteLine("Multi class integer value = " + obj.multiId);
            Console.WriteLine("Multi class string value = " + obj.multiStr);
            obj.BaseMethod();
            obj.SecondMethod();
            Console.WriteLine("*********************");
            Console.WriteLine();
            SecondMain();
            BaseMain();
        }
        private static void SecondMain()
        {
            SecondClass obj = new MultiLevel();
            Console.WriteLine("----SecondClass obj = new MultiLevel()----- ");
            Console.WriteLine("Second class integer value = " + obj.secondId);
            Console.WriteLine("Second class string value = " + obj.secondStr);
            obj.BaseMethod();
            obj.SecondMethod();
            Console.WriteLine("*********************");
            Console.WriteLine();
        }

        private static void BaseMain()
        {
            BaseClass obj = new MultiLevel();
            Console.WriteLine("----BaseClass obj = new MultiLevel()----- ");
            Console.WriteLine("Base class integer value = " + obj.baseId);
            Console.WriteLine("Base class string value = " + obj.baseStr);
            obj.BaseMethod();
            Console.WriteLine("*********************");
            Console.WriteLine();
        }
    }
}