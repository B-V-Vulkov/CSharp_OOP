namespace P04.PizzaCalories.Exceptions
{
    public class ExceptionMessages
    {
        public static string InvalidTypeOfDoughOrBakingTechniqueException =
            "Invalid type of dough.";

        public static string InvalidWeightOfDoughException =
            "Dough weight should be in the range [1..200].";

        public static string InvaliTypeOfToppingException =
            "Cannot place {0} on top of your pizza.";

        public static string InvalidWeightOfToppingException =
            "{0} weight should be in the range [1..50].";

        public static string InvalidLengthOfPizzaName =
            "Pizza name should be between 1 and 15 symbols.";

        public static string InvalidCoundOfToppings =
            "Number of toppings should be in range [0..10].";
    }
}
