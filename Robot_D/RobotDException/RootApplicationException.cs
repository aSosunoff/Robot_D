using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_D.RobotDException
{
    public class RootApplicationException : ApplicationException
    {
        public RootApplicationException(string message) : base(message) { }
    }
}
