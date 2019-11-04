namespace P05.FootballTeamGenerator.Models
{
    using System;

    using Exceptions;

    public class Player
    {
        private string name;
        private Stat stat;

        public Player(string name, Stat stat)
        {
            this.Name = name;
            this.Stat = stat;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNameException);
                }

                this.name = value;
            }
        }

        public Stat Stat
        {
            get
            {
                return this.stat;
            }
            private set
            {
                this.stat = value;
            }
        }

        public double OverallSkill()
        {
            return this.Stat.OverallStat();
        }
    }
}
