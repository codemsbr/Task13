using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13.Exceptions
{
    internal class InvalidAgeException:Exception
    {
        public InvalidAgeException():base()
        {
            
        }

        public InvalidAgeException(string? message):base(message)
        {
            
        }
    }
}
