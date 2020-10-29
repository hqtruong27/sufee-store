using System;
using System.Collections.Generic;
using System.Text;

namespace SS.Utilities.Exceptions
{
    public class SufeeException : Exception
    {
        public SufeeException()
        {
        }

        public SufeeException(string message)
            : base(message)
        {
        }

        public SufeeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}