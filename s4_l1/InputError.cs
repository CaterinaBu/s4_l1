using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4_l1
{
    internal class InputError: Exception
    {
        public InputError(string message): base(message)
        {
        }
        public InputError(string message, Exception inner): base(message, inner)
        {
        }
    }

}
