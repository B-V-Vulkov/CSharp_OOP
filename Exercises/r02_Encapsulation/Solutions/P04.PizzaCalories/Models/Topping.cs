namespace P04.PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;

    using Exceptions;

    public class Topping
    {
        private string type;
        private int weight;

        private Dictionary<string, double> typesTopping = new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (!typesTopping.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvaliTypeOfToppingException, value));
                }

                this.type = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidWeightOfToppingException, this.Type));
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double totalCalories = 2 * this.Weight * this.typesTopping[this.Type.ToLower()];

            return totalCalories;
        }
    }
}
