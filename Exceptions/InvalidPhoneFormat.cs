using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13.Exceptions
{
    internal class InvalidPhoneFormat:Exception
    {
        public InvalidPhoneFormat():base()
        {
            
        }

        public InvalidPhoneFormat(string? message):base(message)
        {
            
        }
    }
}
