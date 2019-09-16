namespace P06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<IBirthdateable> birthdateables = new List<IBirthdateable>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split(" ");
                string type = splittedInput[0];
                string name = splittedInput[1];

                if (type == "Citizen")
                {
                    int age = int.Parse(splittedInput[2]);
                    string id = splittedInput[3];
                    string birthdate = splittedInput[4];

                    birthdateables.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == "Pet")
                {
                    string birthdate = splittedInput[2];

                    birthdateables.Add(new Pet(name, birthdate));
                }
            }

            string specificYear = Console.ReadLine();

            List<string> result = birthdateables
                .Where(b => b.Birthdate.EndsWith(specificYear))
                .Select(b => b.Birthdate)
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
