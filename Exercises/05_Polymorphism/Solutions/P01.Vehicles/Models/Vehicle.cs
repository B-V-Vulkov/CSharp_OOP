namespace P01.Vehicles.Models
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public abstract double AirConditionersConsumption { get; protected set; }

        public abstract double LossOfFuelInPercents { get; protected set; }

        public void Refuel(double fule)
        {
            this.FuelQuantity += (fule - (fule * this.LossOfFuelInPercents / 100));
        }

        public string Drive(double distance)
        {
            double needFule = (this.FuelConsumption + this.AirConditionersConsumption) * distance;

            if (needFule <= this.FuelQuantity)
            {
                this.FuelQuantity -= needFule;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
