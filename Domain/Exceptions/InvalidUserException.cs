using System;

namespace Domain.Exceptions
{
    public class InvalidUserException : ApplicationException
    {
        public InvalidUserException() { }
        public InvalidUserException(string message) : base(message) { }
    }
}
