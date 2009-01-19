using System;
namespace StickyDesk
{
    /// <summary>
    /// Exception class that is thrown when App Data file
    /// is found to be invalid.
    /// </summary>
    class InvalidAppDataException : ApplicationException
    {
        public InvalidAppDataException() { }

        public InvalidAppDataException(string message) : base(message) { }

        public InvalidAppDataException(string message, Exception inner) : base(message, inner) { }

        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected InvalidAppDataException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
