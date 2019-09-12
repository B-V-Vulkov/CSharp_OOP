namespace Restaurant.Beverages
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {
        }

        public double CoffeeMilliliters { get; } = 50;

        public decimal CoffeePrice { get; } = 3.0m;

        public double Caffeine { get; set; }
    }
}
