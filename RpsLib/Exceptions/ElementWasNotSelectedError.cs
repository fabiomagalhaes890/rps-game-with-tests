using System;

namespace RpsLib.Exceptions
{
    public class ElementWasNotSelectedError : Exception
    {
        public ElementWasNotSelectedError() : base("Element was not selected error.") { }

        public ElementWasNotSelectedError(string message) : base(message) { }
    }
}
