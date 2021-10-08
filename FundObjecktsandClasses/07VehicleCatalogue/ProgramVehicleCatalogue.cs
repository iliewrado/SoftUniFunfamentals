using System;
using System.Collections.Generic;
using System.Linq;

namespace _07VehicleCatalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class VehicleCatalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public VehicleCatalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
    class ProgramVehicleCatalogue
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("/", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            VehicleCatalogue catalogue = new VehicleCatalogue();

            while (input[0] != "end")
            {
                string type = input[0];
                string brand = input[1];
                string model = input[2];

                if (type == "Car")
                {
                    double horsePower = double.Parse(input[3]);

                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;
                    catalogue.Cars.Add(car);
                }
                else
                {
                    double weight = double.Parse(input[3]);

                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    catalogue.Trucks.Add(truck);
                }

                input = Console.ReadLine()
                .Split("/", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car item in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck item in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
            
            
        }
    }
}
