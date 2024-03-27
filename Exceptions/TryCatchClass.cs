using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class TryCatchClass
    {
        static int x;
        static int y;

        public static void airthmetic()
        {
            try
            {
                Console.WriteLine("Division program");
                Console.WriteLine("Enter value for X");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for Y");
                y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Divided value is = " + z);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Exception is = " + e.Message);
            }
            catch(NullReferenceException e) {
            }
            /*catch(Exception e) 
            {
            }*/

            finally
            {
                Console.WriteLine("Finally block run");
            }
            
        }
    }
}
