namespace P01.Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class StartUp
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            var carInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);

            var truckInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            vehicles.Add(car);
            vehicles.Add(truck);

            int rowCommans = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rowCommans; i++)
            {
                string input = Console.ReadLine();
                var splittedInput = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0].ToUpper();
                string type = splittedInput[1].ToUpper();

                if (type == "CAR")
                {
                    if (command == "DRIVE")
                    {
                        double distance = double.Parse(splittedInput[2]);

                        Console.WriteLine(vehicles
                            .FirstOrDefault(t => t.GetType().Name == "Car")
                            .Drive(distance));
                    }
                    else if (command == "REFUEL")
                    {
                        double fuel = double.Parse(splittedInput[2]);

                        vehicles
                            .FirstOrDefault(t => t.GetType().Name == "Car")
                            .Refuel(fuel);
                    }
                }
                else if (type == "TRUCK")
                {
                    if (command == "DRIVE")
                    {
                        double distance = double.Parse(splittedInput[2]);

                        Console.WriteLine(vehicles
                            .FirstOrDefault(t => t.GetType().Name == "Truck")
                            .Drive(distance));
                    }
                    else if (command == "REFUEL")
                    {
                        double fuel = double.Parse(splittedInput[2]);

                        vehicles
                            .FirstOrDefault(t => t.GetType().Name == "Truck")
                            .Refuel(fuel);
                    }
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
