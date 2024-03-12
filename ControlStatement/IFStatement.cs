using System;
using System.Globalization;

namespace ControlStatement
{
    internal class IFStatement
    {
        static int num;
           static void IFCondition()
        {
            Console.WriteLine("Enter any Numneric Value");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
        }
            static void IFElseCondition()
            {
             Console.WriteLine("Enter any numeric Value");
             num = Convert.ToInt32(Console.ReadLine());
             if(num % 2 == 0)
              {
               Console.WriteLine("Entered number is Even");
              }
              else
               {
               Console.WriteLine("Entered number is odd");
               }
            }
        static void IFElseIFCondition()
        {
            Console.WriteLine("Enter the total Marks");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 || num > 100)
            {
                Console.WriteLine("Enter the correct numbers");
            }else if(num>0 && num < 50)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Grade is Pass");
            }
        }
        static void Main(string[] args)
        {
            /* Console.WriteLine("Welcome to IF Condition Program");
            IFCondition();
            IFElseCondition();
            IFElseIFCondition(); 
            ControlStatement.SwitchCase.SwitchMain();
            ControlStatement.CallByReference.CBRMain();
            ControlStatement.OutParameter.OutMain();
            ControlStatement.BasicArray.ArrayMain();
            ControlStatement.ArrayToFunction.ArrayFunctionMain();
            ControlStatement.MultiDimensionArray.MultiDimArrMain();
            ControlStatement.JaggeredArray.JaggeredArrMain();
            ControlStatement.ParamParameter.ParamMain();
            ControlStatement.ArrayMethods.ArrayFunctionMain();*/
            ControlStatement.SwitchCase.SwitchMain();
        }
    }
}
