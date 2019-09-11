namespace P03.ShoppingSpree.Models
{
    using System;
    using Exceptions;

    public class Product
    {
        private string name;
        private decimal cost;

        public Product()
        {
                
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.nullOrEmptyNameException);
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0 )
                {
                    throw new ArgumentException(ExceptionMessages.negativeMoneyExceptio);
                }

                this.cost = value;
            }
        }

    }
}
