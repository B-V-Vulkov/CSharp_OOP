namespace P02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.AirConditionersConsumption = 1.4;
        }

        public override double AirConditionersConsumption { get; protected set; }

        public bool IsEmpty { get; set; }

        public override string Drive(double distance)
        {
            double neededFuil = 0;
            if (IsEmpty)
            {
                neededFuil = distance * this.FuelConsumption;
            }
            else if (!IsEmpty)
            {
                neededFuil = distance * (this.FuelConsumption + this.AirConditionersConsumption);
            }

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
