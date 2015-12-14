using System;

namespace Robot_D.RobotDException.DronException
{
    public class MoveException : RootApplicationException
    {
        public MoveException(string message) : base(message) { }
    }
}
