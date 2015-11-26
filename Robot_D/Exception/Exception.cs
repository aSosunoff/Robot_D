using System;

namespace Robot_D.Exception
{
    public class ExceptionUser : ApplicationException
    {
        public ExceptionUser() { }

        public ExceptionUser(string message) : base(message) { }

        
        //public override string Message
        //{
        //    get { return base.Message; }
        //}

        //public Exception(string message, Exception inner) : base(message, inner) { }

        //protected Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}