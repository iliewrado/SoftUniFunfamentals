using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace _06VehicleCatalogue
{
    class ProgramVehicleCatalogue
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Catalogue> catalogues = new List<Catalogue>();
            double carPower = 0;
            double truckPower = 0;
            int carCount = 0;
            int truckCount = 0;

            while (input[0] != "End")
            {
                Catalogue catalogue = new Catalogue
                (
                    input[0],
                    input[1],
                    input[2],
                    double.Parse(input[3])
                );
                catalogues.Add(catalogue);

                if (input[0] == "car")
                {
                    carPower += double.Parse(input[3]);
                    carCount++;
                }
                else
                {
                    truckPower += double.Parse(input[3]);
                    truckCount++;
                }
                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            string model = string.Empty;

            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Catalogue vehicle in catalogues.Where(x => x.Model == model))
                {
                    Console.WriteLine($"Type: {vehicle.Type.First().ToString().ToUpper() + vehicle.Type.Substring(1)}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
            }
            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(carPower / carCount):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {carCount:f2}.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(truckPower / truckCount):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckCount:f2}.");
            }
        }
    }
    class Catalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public Catalogue(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
    }
}
