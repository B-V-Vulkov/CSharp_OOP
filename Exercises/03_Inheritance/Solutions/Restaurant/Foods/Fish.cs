namespace Restaurant.Foods
{
    public class Fish : MainDish
    {
        public Fish(string name, decimal price, double grams) 
            : base(name, price, grams)
        {
        }

        public override double Grams => 22;
    }
}
