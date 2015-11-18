using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Dron_Exception
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