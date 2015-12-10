using System;

namespace Robot_D.Exception_App.Exception_Spare_Parts
{
    public class Exception_Command : ApplicationException
    {
        public Exception_Command(string message) : base(message) { }
    }
}
