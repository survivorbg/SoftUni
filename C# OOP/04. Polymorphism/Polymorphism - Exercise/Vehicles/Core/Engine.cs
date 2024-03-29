﻿using Vehicles.Core.Interfaces;
using Vehicles.Factories;
using Vehicles.Factories.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        private ICollection<IVehicle> vehicles;

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
            vehicles = new List<IVehicle>();
        }

        public void Run()
        {
            IVehicle car = CreateVehicle();
            IVehicle truck = CreateVehicle();

            vehicles.Add(car);
            vehicles.Add(truck);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                ProcessCommand();
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }

            foreach  (IVehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        private void ProcessCommand()
        {
            string[] commandTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = commandTokens[0];
            string vehicleType = commandTokens[1];

            IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);
            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            switch (command)
            {
                case "Drive":
                    vehicle.Drive(double.Parse(commandTokens[2]));
                    break;
                case "Refuel":
                    vehicle.Refuel(double.Parse(commandTokens[2]));
                    break;
                default:
                    break;
            }
        }

        private IVehicle CreateVehicle()
        {
            string[] tokens = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            IVehicle vehicle = vehicleFactory.Create(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]));
            return vehicle;
        }
    }
}
