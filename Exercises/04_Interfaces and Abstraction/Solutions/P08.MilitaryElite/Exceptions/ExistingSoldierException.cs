namespace MilitaryElite.Exceptions
{
    using System;

    public class ExistingSoldierException : Exception
    {

        private const string message = "This soldier already exist.";

        public ExistingSoldierException()
            : base(message)
        {

        }

        public ExistingSoldierException(string message) 
            : base(message)
        {

        }
    }
}
