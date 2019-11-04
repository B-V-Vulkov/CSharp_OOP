namespace P05.FootballTeamGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Exceptions;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            : this()
        {
            this.Name = name;
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

        public int Rating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(this.players.Average(p => p.OverallSkill()));
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player playerForRemove = players
                .FirstOrDefault(p => p.Name == name);

            if (!players.Contains(playerForRemove))
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.MissingPlayerException, name, this.Name));
            }

            this.players.Remove(playerForRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
