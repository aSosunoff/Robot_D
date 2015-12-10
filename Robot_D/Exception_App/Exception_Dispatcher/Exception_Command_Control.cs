using System;

namespace Robot_D.Exception_App.Exception_Dispatcher
{
    public class Exception_Command_Control : ApplicationException
    {
        //public ExceptionUser() { }

        public Exception_Command_Control(string message) : base(message) { }

        
        //public override string Message
        //{
        //    get { return base.Message; }
        //}

        //public Exception(string message, Exception inner) : base(message, inner) { }

        //protected Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}