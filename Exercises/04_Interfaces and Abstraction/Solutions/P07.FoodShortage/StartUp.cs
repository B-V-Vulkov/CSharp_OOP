namespace P07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfPerson = int.Parse(Console.ReadLine());

            List<IBuyer> people = new List<IBuyer>();

            for (int i = 1; i <= numberOfPerson; i++)
            {
                string[] splittedInput = Console.ReadLine()
                    .Split(" ");

                string name = splittedInput[0];
                int age = int.Parse(splittedInput[1]);

                if (splittedInput.Length == 3)
                {
                    string group = splittedInput[2];

                    people.Add(new Rebel(name, age, group));
                }
                else if (splittedInput.Length == 4)
                {
                    string id = splittedInput[2];
                    string birthdate = splittedInput[3];

                    people.Add(new Citizen(name, age, id, birthdate));
                }
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var currentBuyer = people
                    .FirstOrDefault(n => n.Name == command);

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }
            }

            int totalFood = people.Sum(f => f.Food);

            Console.WriteLine(totalFood);

            
        }
    }
}
