namespace P02.VehiclesExtension
{
    using System;
    using System.Collections.Generic;

    using Models;
    using Readers;

    public class StartUp
    {
        public static void Main()
        {
            var vehicles = new List<Vehicle>();

            vehicles.Add(CreateCar());
            vehicles.Add(CreateTruck());
            vehicles.Add(CreateBus());

            int numberCommans = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberCommans; i++)
            {
                var splittedInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0];
                string type = splittedInput[1];
                double value = double.Parse(splittedInput[2]);

                try
                {
                    if (command == "Drive")
                    {
                        foreach (var vehicle in vehicles)
                        {
                            if (vehicle.GetType().Name == type)
                            {
                                vehicle.Drive(value);
                            }
                        }
                    }
                    else if (command == "Refuel")
                    {
                        foreach (var vehicle in vehicles)
                        {
                            if (vehicle.GetType().Name == type)
                            {
                                vehicle.Refuel(value);
                            }
                        }
                    }
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
            }
        }

        public static Car CreateCar()
        {
            var vehicleInfoReader = GetVehicleInfo();

            return new Car(vehicleInfoReader.FuelQuantity, 
                vehicleInfoReader.FuelConsumption, 
                vehicleInfoReader.TankCapacity);
        }

        public static Truck CreateTruck()
        {
            var vehicleInfoReader = GetVehicleInfo();

            return new Truck(vehicleInfoReader.FuelQuantity,
                vehicleInfoReader.FuelConsumption,
                vehicleInfoReader.TankCapacity);
        }

        public static Bus CreateBus()
        {
            var vehicleInfoReader = GetVehicleInfo();

            return new Bus(vehicleInfoReader.FuelQuantity,
                vehicleInfoReader.FuelConsumption,
                vehicleInfoReader.TankCapacity);
        }

        public static VehicleInfoReader GetVehicleInfo()
        {
            var inputInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            VehicleInfoReader vehicleInfoReader = new VehicleInfoReader();

            vehicleInfoReader.FuelQuantity = double.Parse(inputInfo[1]);
            vehicleInfoReader.FuelConsumption = double.Parse(inputInfo[2]);
            vehicleInfoReader.TankCapacity = double.Parse(inputInfo[3]);

            return vehicleInfoReader;
        }
    }
}
