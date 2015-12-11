using System;

namespace Robot_D.RobotDException.DronException
{
    public class MoveException : ApplicationException
    {
        public MoveException(string message) : base(message) { }
    }
}
