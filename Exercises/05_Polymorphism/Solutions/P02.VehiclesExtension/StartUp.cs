namespace P02.VehiclesExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            var truckInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            var busInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int rowCommans = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rowCommans; i++)
            {
                string input = Console.ReadLine();
                var splittedInput = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0].ToUpper();
                string type = splittedInput[1].ToUpper();
                double value = double.Parse(splittedInput[2]);

                try
                {
                    if (type == "CAR")
                    {
                        if (command == "DRIVE")
                        {
                            Console.WriteLine(car.Drive(value));
                        }
                        else if (command == "REFUEL")
                        {
                            car.Refuel(value);
                        }
                    }

                    else if (type == "TRUCK")
                    {
                        if (command == "DRIVE")
                        {
                            Console.WriteLine(truck.Drive(value));
                        }
                        else if (command == "REFUEL")
                        {
                            truck.Refuel(value);
                        }
                    }

                    else if (type == "BUS")
                    {
                        if (command == "DRIVE")
                        {
                            bus.IsEmpty = false;
                            Console.WriteLine(bus.Drive(value));
                        }
                        else if (command == "DRIVEEMPTY")
                        {
                            bus.IsEmpty = true;
                            Console.WriteLine(bus.Drive(value));
                        }
                        else if (command == "REFUEL")
                        {
                            bus.Refuel(value);
                        }
                    }
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
