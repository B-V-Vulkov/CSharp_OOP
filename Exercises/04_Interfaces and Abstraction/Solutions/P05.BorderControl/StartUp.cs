namespace P05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInpu = input.Split(" ");

                if (splittedInpu.Length == 2)
                {
                    string model = splittedInpu[0];
                    string id = splittedInpu[1];

                    identifiables.Add(new Robot(model, id));
                }
                else if (splittedInpu.Length == 3)
                {
                    string name = splittedInpu[0];
                    int age = int.Parse(splittedInpu[1]);
                    string id = splittedInpu[2];

                    identifiables.Add(new Citizen(name, age, id));
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var identifiable in identifiables.Where(x => x.Id.EndsWith(fakeId)))
            {
                Console.WriteLine(identifiable.Id);
            }
        }
    }
}
