namespace P03.ShoppingSpree.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class Engine
    {
        private List<Person> people = new List<Person>();
        private List<Product> products = new List<Product>();

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPeopleInput();
                ReadProductsInput();

                string command = string.Empty;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] commandTokens = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person person = people
                        .FirstOrDefault(n => n.Name == personName);

                    Product product = products
                        .FirstOrDefault(n => n.Name == productName);

                    if (person != null && product != null)
                    {
                        try
                        {
                            person.BuyProduct(product);
                            Console.WriteLine($"{personName} bought {productName}");
                        }
                        catch (InvalidOperationException ioex)
                        {
                            Console.WriteLine(ioex.Message);
                        }
                    }
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException are)
            {
                Console.WriteLine(are.Message);
            }
        }

        private void ReadPeopleInput()
        {
            string[] personTokens = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in personTokens)
            {
                string[] personInfo = person
                    .Split("=");

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                this.people.Add(new Person(name, money));
            }
        }
        private void ReadProductsInput()
        {
            string[] produkcTokens = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in produkcTokens)
            {
                string[] productInfo = product
                    .Split("=");

                string name = productInfo[0];
                decimal cost = decimal.Parse(productInfo[1]);

                this.products.Add(new Product(name, cost));
            }
        }
    }
}
