using System;

namespace RpsLib.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError() : base("No such strategy error.") { }

        public NoSuchStrategyError(string message) : base(message) { }
    }
}
