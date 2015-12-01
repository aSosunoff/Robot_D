using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_D.Exception.Exception_Center_Layer
{
    public class Exception_Dron : ApplicationException
    {
        public Exception_Dron(string message) : base(message) { }
    }
}
