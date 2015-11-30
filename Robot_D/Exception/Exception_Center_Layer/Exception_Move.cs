using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_D.Exception.Exception_Center_Layer
{
    public class Exception_Move : ApplicationException
    {
        public Exception_Move(string message) : base(message) { }
    }
}
