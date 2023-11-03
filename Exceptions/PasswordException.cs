using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13.Exceptions
{
    internal class PasswordException : Exception
    {
        public PasswordException():base()
        {
        }

        public PasswordException(string? message) : base(message)
        {
        }
    }
}
