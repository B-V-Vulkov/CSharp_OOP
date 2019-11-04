namespace P04.PizzaCalories.Core
{
    using System;
    using Models;

    public class Engine
    {
        private string input = string.Empty;

        public void Run()
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine()
                    .Split(" ");

                string pizzaName = pizzaInfo[1];

                Pizza pizza = new Pizza(pizzaName);

                string[] doughInfo = Console.ReadLine()
                    .Split(" ");

                string typeDough = doughInfo[1];
                string typeBakingTechnique = doughInfo[2];
                int doughWeight = int.Parse(doughInfo[3]);

                Dough dough = new Dough(typeDough, typeBakingTechnique, doughWeight);

                pizza.Dough = dough;

                string toppings = Console.ReadLine();

                while (toppings != "END")
                {
                    string[] toppingInfo = toppings
                        .Split(" ");

                    string typeTopping = toppingInfo[1];
                    int toppingWeight = int.Parse(toppingInfo[2]);

                    Topping topping = new Topping(typeTopping, toppingWeight);

                    pizza.AddTopping(topping);

                    toppings = Console.ReadLine();
                }

                Console.WriteLine(pizza);

            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}
