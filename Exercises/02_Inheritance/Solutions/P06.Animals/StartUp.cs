namespace Animals
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Common.Enumerations;
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

                    Gender gender = Gender.Unknown;

                    if (animalInfo.Length == 3)
                    {
                        if (animalInfo[2] == Gender.Male.ToString())
                        {
                            gender = Gender.Male;
                        }
                        else if (animalInfo[2] == Gender.Female.ToString())
                        {
                            gender = Gender.Female;
                        }
                    }

                    command = command.ToLower();

                    if (command == "Dog")
                    {
                        var animal = new Dog(name, age, gender);
                        animals.Add(animal);
                    }
                    else if (command == "Cat")
                    {
                        var animal = new Cat(name, age, gender);
                        animals.Add(animal);
                    }
                    else if (command == "Frog")
                    {
                        var animal = new Frog(name, age, gender);
                        animals.Add(animal);
                    }
                    else if (command == "Kitten")
                    {
                        var animal = new Kitten(name, age);
                        animals.Add(animal);
                    }
                    else if (command == "Tomcat")
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

