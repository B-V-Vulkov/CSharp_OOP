namespace MilitaryElite.Exceptions
{
    using System;

    public class InvalidCorpsException : Exception
    {
        private const string message = "Corps does not exist.";

        public InvalidCorpsException()
            :base(message)
        {

        }

        public InvalidCorpsException(string message)
            : base(message)
        {
            
        }
    }
}
