namespace P04.PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;

    using Exceptions;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidLengthOfPizzaName);
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCoundOfToppings);
            }

            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            double totalCalories = this.dough.GetCalories();

            foreach (var topping in this.toppings)
            {
                totalCalories += topping.GetCalories();
            }

            return totalCalories;
        }

        public override string ToString()
        {
            double totalCalories = this.GetCalories();

            return $"{this.Name} - {totalCalories:f2} Calories.";
        }
    }
}
