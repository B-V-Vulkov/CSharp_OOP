namespace P05.FootballTeamGenerator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;
    using Exceptions;

    public class Engine
    {
        private readonly List<Team> teams;

        public Engine()
        {
            teams = new List<Team>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] commandTokens = command
                        .Split(";");

                    string typeCommand = commandTokens[0];
                    string teamName = commandTokens[1];

                    if (typeCommand == "Team")
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }

                    else if (typeCommand == "Add")
                    {
                        Team team = ValidateTeam(teamName);
                        Stat stat = CreateStat(commandTokens);

                        string playerName = commandTokens[2];

                        Player player = new Player(playerName, stat);

                        team.AddPlayer(player);
                    }

                    else if (typeCommand == "Remove")
                    {
                        Team team = ValidateTeam(teamName);
                        string playerName = commandTokens[2];
                        team.RemovePlayer(playerName);
                    }

                    else if (typeCommand == "Rating")
                    {
                        Team team = ValidateTeam(teamName);
                        Console.WriteLine(team);
                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                command = Console.ReadLine();
            }
        }

        private Stat CreateStat(string[] commandTokens)
        {
            int endurance = int.Parse(commandTokens[3]);
            int sprint = int.Parse(commandTokens[4]);
            int dribble = int.Parse(commandTokens[5]);
            int passing = int.Parse(commandTokens[6]);
            int shooting = int.Parse(commandTokens[7]);

            Stat stat = new Stat(endurance, sprint, dribble, passing, shooting);
            return stat;
        }

        private Team ValidateTeam(string name)
        {
            Team team = teams
                .FirstOrDefault(t => t.Name == name);

            if (!teams.Contains(team))
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.MissingTeamException, name));
            }

            return team;
        }
    }
}
