using System;

namespace RpsLib.Exceptions
{
    public class NotInformedNameError : Exception
    {
        public NotInformedNameError() : base("Not informed name error.") { }

        public NotInformedNameError(string message) : base(message) { }
    }
}
