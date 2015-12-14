using System;

namespace Robot_D.RobotDException.DispatcherException
{
    public class DevideCommandException : RootApplicationException
    {
        public DevideCommandException(string message) : base(message) { }
    }
}
