using System;

namespace Robot_D.RobotDException.DispatcherException
{
    public class CommandControlException : RootApplicationException
    {
        public CommandControlException(string message) : base(message) { }   
    }
}