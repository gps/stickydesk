using System;
namespace StickyDesk
{
    /// <summary>
    /// Exception class that is thrown when App Data file
    /// is found to be invalid.
    /// </summary>
    class InvalidAppDataException : Exception
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public InvalidAppDataException()
        {
        }

        /// <summary>
        /// Constructor.
        /// Initializes Error Message to strErrMsg.
        /// </summary>
        /// <param name="ErrMsg">Error Message</param>
        public InvalidAppDataException(string ErrMsg)
        {
            Message = ErrMsg;
        }

        /// <summary>
        /// Contains Error Message.
        /// </summary>
        public new string Message { get; private set; }
    }
}
