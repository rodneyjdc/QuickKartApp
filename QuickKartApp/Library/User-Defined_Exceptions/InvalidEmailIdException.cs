using System;
using System.Collections.Generic;
using System.Text;

namespace Library.User_Defined_Exceptions
{
    public class InvalidEmailIdException : Exception
    {
        public InvalidEmailIdException()
        {
        }

        public InvalidEmailIdException(string message) : base(message)
        {

        }
    }
}
