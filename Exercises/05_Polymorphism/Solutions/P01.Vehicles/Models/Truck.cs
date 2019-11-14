namespace P01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
            this.AirConditionersConsumption = 1.6;
            this.LossOfFuelInPercents = 5;
        }

        public override double AirConditionersConsumption { get; protected set; }

        public override double LossOfFuelInPercents { get; protected set; }
    }
}
