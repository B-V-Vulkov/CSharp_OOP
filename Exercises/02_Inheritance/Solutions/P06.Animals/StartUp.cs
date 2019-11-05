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
            var animals = new List<IAnimal>();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine()
                    .Split(' ');

                string name = null;
                int age = 0;
                Gender gender = Gender.Unknown;

                try
                {
                    if (animalInfo.Length == 2)
                    {
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);
                    }
                    else if (animalInfo.Length == 3)
                    {
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);

                        string genderString = animalInfo[2];

                        if (genderString == Gender.Male.ToString())
                        {
                            gender = Gender.Male;
                        }
                        else if (genderString == Gender.Female.ToString())
                        {
                            gender = Gender.Female;
                        }
                        else
                        {
                            throw new InvalidOperationException("Invalid input!");
                        }

                        if (age < 0)
                        {
                            throw new InvalidOperationException("Invalid input!");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid input!");
                    }

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
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}");
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine($"{animal.ProduceSound()}");
            }
        }
    }
}

