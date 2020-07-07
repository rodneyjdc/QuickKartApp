using System;
using System.Collections.Generic;
using System.Text;

namespace Library.User_Defined_Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException()
        {

        }

        public InvalidPhoneNumberException(string message) : base(message)
        {

        }
    }
}
