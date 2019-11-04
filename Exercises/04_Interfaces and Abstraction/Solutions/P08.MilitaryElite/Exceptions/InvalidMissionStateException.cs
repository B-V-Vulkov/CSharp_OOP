namespace MilitaryElite.Exceptions
{
    using System;

    class InvalidMissionStateException : Exception
    {
        private const string message = "Mission state does not exist.";

        public InvalidMissionStateException()
            :base(message)
        {

        }

        public InvalidMissionStateException(string message) 
            : base(message)
        {

        }
    }
}
