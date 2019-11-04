namespace P04.PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;

    using Exceptions;

    public class Dough
    {
        private string typeDough;
        private string typeBakingTechnique;
        private int weight;

        private static Dictionary<string, double> typesDough = new Dictionary<string, double>
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };

        private static Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

        public Dough(string typeDough, string typeBakingTechnique, int weight)
        {
            this.TypeDough = typeDough;
            this.TypeBakingTechnique = typeBakingTechnique;
            this.Weight = weight;
        }

        public string TypeDough
        {
            get
            {
                return this.typeDough;
            }
            private set
            {
                if (!typesDough.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidTypeOfDoughOrBakingTechniqueException);
                }

                this.typeDough = value;
            }
        }

        public string TypeBakingTechnique
        {
            get
            {
                return this.typeBakingTechnique;
            }
            private set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(
                        ExceptionMessages.InvalidTypeOfDoughOrBakingTechniqueException);
                }

                this.typeBakingTechnique = value;
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(ExceptionMessages
                        .InvalidWeightOfDoughException);
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double totalCalories = 2 * this.Weight *
                typesDough[this.TypeDough.ToLower()] *
                bakingTechniques[this.TypeBakingTechnique.ToLower()];

            return totalCalories;
        }
    }
}
