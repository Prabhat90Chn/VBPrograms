using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Exceptions
{
    internal class UserAlreadyLoggedInException:Exception
    {
            public UserAlreadyLoggedInException() : base() { 
            }
            public UserAlreadyLoggedInException(string msg) : base(msg)
            {
            }

            public UserAlreadyLoggedInException(string msg , Exception innerException) : base(msg, innerException)
            {
            }
            public UserAlreadyLoggedInException(SerializationInfo sinfo, StreamingContext scontext) : base(sinfo,scontext)
            {
            }     
    }
    public class CustomExceptoionDemo
    {
        public static void ExceptionMain()
        {
            try
            {
                throw new UserAlreadyLoggedInException("Exception occured");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
