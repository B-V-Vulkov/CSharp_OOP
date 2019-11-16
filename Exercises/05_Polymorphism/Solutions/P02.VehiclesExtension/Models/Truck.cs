namespace P02.VehiclesExtension.Models
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.AirConditionersConsumption = 1.6;
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

        public override void Refuel(double fule)
        {
            if (this.FuelQuantity + fule > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fule} fuel in the tank");
            }
            else if (fule <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            this.FuelQuantity += fule * 0.95;
        }
    }
}
