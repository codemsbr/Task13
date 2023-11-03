using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13.Exceptions
{
    internal class InvalidNameException:Exception
    {
        public InvalidNameException():base()
        {
            
        }

        public InvalidNameException(string message):base(message)
        {
            
        }
    }
}
