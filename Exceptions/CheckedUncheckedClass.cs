using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class CheckedUncheckedClass
    {
       
            public static void checkedMain()
            {
            try
            {
                checked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);// this will throw error
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }finally
            {
                unchecked
                {
                    int val = int.MaxValue;
                    Console.WriteLine("*********************");
                    Console.WriteLine("Unchecked value = "+val + 2);// this will trim the output and show but doesnt throw exception
                }
            }
                
            }
        
    }
}
