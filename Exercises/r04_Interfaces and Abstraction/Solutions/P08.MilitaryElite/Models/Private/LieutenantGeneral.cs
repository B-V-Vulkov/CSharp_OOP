namespace MilitaryElite.Models.Private
{
    using System.Collections.Generic;

    using Contracts.Private;
    using Exceptions;
    using Contracts;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<ISoldier> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => this.privates;

        public void AddPrivate(ISoldier @private)
        {
            if (this.privates.Contains(@private))
            {
                throw new ExistingSoldierException();
            }

            this.privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var soldier in this.privates)
            {
                sb.AppendLine($"  {soldier.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
