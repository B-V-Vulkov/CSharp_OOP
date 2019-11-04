namespace MilitaryElite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Models.Spy;
    using Models.Private;

    public class ConsoleEngine
    {
        private readonly ICollection<ISoldier> army = new List<ISoldier>();

        public ConsoleEngine()
        {

        }

        public void Run()
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splittedCommand = command
                    .Split(" ");

                string type = splittedCommand[0];
                string id = splittedCommand[1];
                string firstName = splittedCommand[2];
                string lastName = splittedCommand[3];

                if (type == "Private")
                {
                    decimal salary = decimal.Parse(splittedCommand[4]);
                    Private @private = new Private(id, firstName, lastName, salary);
                    this.army.Add(@private);
                }

                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(splittedCommand[4]);
                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

                    string[] privatesToAdd = splittedCommand
                        .Skip(5)
                        .ToArray();

                    foreach (var privateId in privatesToAdd)
                    {
                        ISoldier soldierToAdd = this.army
                            .FirstOrDefault(s => s.Id == privateId);

                        if (soldierToAdd != null)
                        {
                            general.AddPrivate(soldierToAdd);
                        }
                    }

                    this.army.Add(general);
                }

                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(splittedCommand[4]);
                    string corps = splittedCommand[5];
                    try
                    {
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                        string[] repairsToAdd = splittedCommand
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < repairsToAdd.Length; i += 2)
                        {
                            string partName = repairsToAdd[i];
                            int hoursWorked = int.Parse(repairsToAdd[i + 1]);
                            Repair repair = new Repair(partName, hoursWorked);
                            engineer.AddRepair(repair);
                        }

                        this.army.Add(engineer);
                    }
                    catch (Exception)
                    {

                    }
                }

                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(splittedCommand[4]);
                    string corps = splittedCommand[5];

                    try
                    {
                        Commando commando = new Commando(id, firstName, lastName, salary, corps);

                        string[] missionsToAdd = splittedCommand
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < missionsToAdd.Length; i += 2)
                        {
                            string codeName = missionsToAdd[i];
                            string missionState = missionsToAdd[i + 1];

                            try
                            {
                                Mission mission = new Mission(codeName, missionState);
                                commando.AddMission(mission);
                            }
                            catch (Exception)
                            {

                            }
                        }

                        this.army.Add(commando);
                    }
                    catch (Exception)
                    {

                    }
                }

                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(splittedCommand[4]);
                    Spy spy = new Spy(id, firstName, lastName, codeNumber);

                    this.army.Add(spy);
                }
            }

            PrintOutput();
        }

        public void PrintOutput()
        {
            foreach (var soldier in this.army)
            {
                Type type = soldier.GetType();

                Object actual = Convert.ChangeType(soldier, type);

                Console.WriteLine(actual);
            }
        }
    }
}
