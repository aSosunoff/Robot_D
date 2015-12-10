using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_D.Exception_App
{
    public class Exception_Devide_Command : ApplicationException
    {
        public Exception_Devide_Command(string message) : base(message){}
    }
}
