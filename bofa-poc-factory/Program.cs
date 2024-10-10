using bofa_poc_factory.Factory;
using bofa_poc_factory.Interface.FactoryMethodPatternApp;
using System;

namespace FactoryMethodPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of the factory
            var vehicleFactory = new VehicleFactory();

            // Menu
            Console.WriteLine("Select a vehicle type to create:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.Write("Enter choice (1 or 2): ");
            string choice = Console.ReadLine();

            VehicleType vehicleType;
            switch (choice)
            {
                case "1":
                    vehicleType = VehicleType.Tesla;
                    break;
                case "2":
                    vehicleType = VehicleType.Motorcycle;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. see ya!");
                    return;
            }

            // Create the vehicle using the factory method
            IVehicle vehicle = vehicleFactory.CreateVehicle(vehicleType);

            // Use the created vehicle object
            Console.WriteLine("\nVehicle created successfully!\n");
            vehicle.Drive();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
