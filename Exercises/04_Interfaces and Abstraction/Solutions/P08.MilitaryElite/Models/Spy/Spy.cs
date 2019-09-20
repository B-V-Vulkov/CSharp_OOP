namespace MilitaryElite.Models.Spy
{
    using System;

    using Contracts.Spy;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            return base.ToString().TrimEnd() + Environment.NewLine +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
