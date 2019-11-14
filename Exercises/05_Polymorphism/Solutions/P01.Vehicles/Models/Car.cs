namespace P01.Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
            this.AirConditionersConsumption = 0.9;
            this.LossOfFuelInPercents = 0;
        }

        public override double AirConditionersConsumption { get; protected set; }

        public override double LossOfFuelInPercents { get; protected set; }
    }
}
