using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException() { }
        public ConnectionException(string error) : base(error) { }
    }
}
