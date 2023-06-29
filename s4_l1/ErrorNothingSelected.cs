using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4_l1
{
    internal class ErrorNothingSelected : Exception
    {
        public ErrorNothingSelected(string message): base(message)
        {
        }
        public ErrorNothingSelected(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
