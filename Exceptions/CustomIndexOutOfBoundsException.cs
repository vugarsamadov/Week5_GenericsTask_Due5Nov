using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week5_GenericsTask_Due5Nov.Exceptions
{
    internal class CustomIndexOutOfBoundsException : Exception
    {
        public CustomIndexOutOfBoundsException()
        {
        }

        public CustomIndexOutOfBoundsException(string? message) : base(message)
        {
        }

        public CustomIndexOutOfBoundsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CustomIndexOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
