using System;

namespace RippleDotNet.Exceptions
{
    public class RippleException : Exception
    {
        public RippleException() { }

        public RippleException(string message) : base(message){ }
    }
}
