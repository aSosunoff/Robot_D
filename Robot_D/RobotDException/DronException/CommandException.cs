using System;

namespace Robot_D.RobotDException.DronException
{
    public class CommandException : ApplicationException
    {
        public CommandException(string message) : base(message) { }
    }
}
