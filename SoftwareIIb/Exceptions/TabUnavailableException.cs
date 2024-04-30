using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb.Exceptions
{
    internal class TabUnavailableException : Exception
    {
        public TabUnavailableException() { }
        public TabUnavailableException(string message) : base(message) { }
        public TabUnavailableException(string message,  Exception innerException) : base(message, innerException) { }
    }
}
