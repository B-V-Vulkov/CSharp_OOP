namespace NeedForSpeed.Motorcycle
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 8.0;

        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;
    }
}
