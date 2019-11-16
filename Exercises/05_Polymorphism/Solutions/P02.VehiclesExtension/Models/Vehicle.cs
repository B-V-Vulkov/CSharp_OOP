namespace P02.VehiclesExtension.Models
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get 
            { 
                return this.fuelQuantity;
            }
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public abstract double AirConditionersConsumption { get; protected set; }

        public virtual void Refuel(double fule)
        {
            if (this.FuelQuantity + fule > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fule} fuel in the tank");
            }
            else if (fule <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            this.fuelQuantity += fule;
        }

        public abstract string Drive(double distance);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
