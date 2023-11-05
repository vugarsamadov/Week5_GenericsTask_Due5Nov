using System.Runtime.Serialization;

namespace Week5_GenericsTask_Due5Nov.Exceptions
{
    [Serializable]
    internal class CustomCustomArgumentOutOfBoundsException : Exception
    {
        public CustomCustomArgumentOutOfBoundsException()
        {
        }

        public CustomCustomArgumentOutOfBoundsException(string? message) : base(message)
        {
        }

        public CustomCustomArgumentOutOfBoundsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CustomCustomArgumentOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}