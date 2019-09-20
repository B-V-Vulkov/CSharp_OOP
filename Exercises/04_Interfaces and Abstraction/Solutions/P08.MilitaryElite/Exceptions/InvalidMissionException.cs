namespace MilitaryElite.Exceptions
{
    using System;

    public class InvalidMissionException : Exception
    {
        private const string message = "Mission does not exist.";

        public InvalidMissionException()
            :base(message)
        {

        }

        public InvalidMissionException(string message)
            : base(message)
        {

        }
    }
}
