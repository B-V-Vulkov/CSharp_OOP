namespace Animals
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Models;

    public class StartUp
    {
        public static void Main()
        {

            var animals = new List<Animal>();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine()
                    .Split(' ');

                try
                {
                    string name = String.Empty;

                    if (animalInfo.Length > 0)
                    {
                        name = animalInfo[0];
                    }

                    if (!int.TryParse(animalInfo[1], out int age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    string gender = string.Empty;

                    if (animalInfo.Length == 3)
                    {
                        gender = animalInfo[2];
                    }

                    command = command.ToLower();

                    if (command == "dog")
                    {
                        var animal = new Dog(name, age, gender);
                        animals.Add(animal);
                    }
                    else if (command == "cat")
                    {
                        var animal = new Cat(name, age, gender);
                        animals.Add(animal);
                    }
                    else if (command == "frog")
                    {
                        var animal = new Frog(name, age, gender);
                        animals.Add(animal);
                    }
                    else if (command == "kitten")
                    {
                        var animal = new Kitten(name, age);
                        animals.Add(animal);
                    }
                    else if (command == "tomcat")
                    {
                        var animal = new Tomcat(name, age);
                        animals.Add(animal);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine($"{animal.ProduceSound()}");
            }
        }
    }
}

