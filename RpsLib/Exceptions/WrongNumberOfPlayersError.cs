using System;

namespace RpsLib.Exceptions
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError() : base("Wrong number of players error.") { }

        public WrongNumberOfPlayersError(string message) : base(message) { }
    }
}
