namespace Restaurant.Foods
{
    public class Food : Product
    {
        private double grams;

        public Food(string name, decimal price, double grams)
            : base(name, price)
        {
            this.Grams = grams;
        }

        public virtual double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                this.grams = value;
            }
        }
    }
}
