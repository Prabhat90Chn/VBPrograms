using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Exceptions.TryCatchClass.airthmetic();
                Exceptions.CustomExceptoionDemo.ExceptionMain();*/
                Exceptions.CheckedUncheckedClass.checkedMain();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
