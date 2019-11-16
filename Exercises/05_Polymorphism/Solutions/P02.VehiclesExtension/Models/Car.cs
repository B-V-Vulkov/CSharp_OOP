namespace P02.VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.AirConditionersConsumption = 0.9;
        }

        public override double AirConditionersConsumption { get; protected set; }

        public override string Drive(double distance)
        {
            double neededFuil = distance * this.FuelConsumption + AirConditionersConsumption;
            bool canDrive = this.FuelQuantity >= neededFuil;

            if (canDrive)
            {
                this.FuelQuantity -= neededFuil;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }
    }
}
