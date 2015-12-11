using System;

namespace Robot_D.RobotDException.DispatcherException
{
    public class CommandControlException : ApplicationException
    {
        //public ExceptionUser() { }

        public CommandControlException(string message) : base(message) { }

        
        //public override string Message
        //{
        //    get { return base.Message; }
        //}

        //public Exception(string message, Exception inner) : base(message, inner) { }

        //protected Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}