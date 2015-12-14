using System;

namespace Robot_D.RobotDException.DronException
{
    public class CommandException : RootApplicationException
    {
        public CommandException(string message) : base(message) { }
    }
}
