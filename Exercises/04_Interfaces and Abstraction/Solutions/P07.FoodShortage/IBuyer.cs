namespace P07.FoodShortage
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; set; }
        void BuyFood();
    }
}
