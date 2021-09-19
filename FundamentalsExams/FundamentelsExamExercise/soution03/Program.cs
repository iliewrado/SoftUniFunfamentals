using System;
using System.Collections.Generic;
using System.Linq;

namespace soution03
{
    class Program
    {
        class Vehicle
        {
            public string Car { get; set; }
            public int Mileage { get; set; }
            public int Fuel { get; set; }
            public Vehicle()
            {

            }
        }
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Vehicle> vechicles = new List<Vehicle>();

            for (int i = 0; i < count; i++)
            {
                Vehicle vehicle = new Vehicle();
                string[] info = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

                vehicle.Car = info[0];
                vehicle.Mileage = int.Parse(info[1]);
                vehicle.Fuel = int.Parse(info[2]);
                vechicles.Add(vehicle);
            }

            string[] command = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Stop")
            {
                string car = command[1];

                if (command[0] == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);
                    foreach (var item in vechicles)
                    {
                        if (item.Car.Contains(car))
                        {
                            if (item.Fuel >= fuel)
                            {
                                item.Fuel -= fuel;
                                item.Mileage += distance;
                                Console.WriteLine($"{item.Car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                                if (item.Mileage >= 100000)
                                {
                                    Console.WriteLine($"Time to sell the {item.Car}!");
                                    vechicles.Remove(item);
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not enough fuel to make that ride");
                                break;
                            }
                        }
                    }
                }
                else if (command[0] == "Refuel")
                {
                    int fuel = int.Parse(command[2]);
                    foreach (var item in vechicles)
                    {
                        if (item.Car.Contains(car))
                        {
                            if (item.Fuel + fuel > 75)
                            {
                                fuel = 75 - item.Fuel;
                                item.Fuel = 75;
                            }
                            else
                            {
                                item.Fuel += fuel;
                            }
                            Console.WriteLine($"{item.Car} refueled with {fuel} liters");
                            break;
                        }
                    }
                }
                else if (command[0] == "Revert")
                {
                    int kilometers = int.Parse(command[2]);
                    foreach (var item in vechicles)
                    {
                        if (item.Car.Contains(car))
                        {
                            item.Mileage -= kilometers;
                            if (item.Mileage < 10000)
                            {
                                item.Mileage = 10000;
                            }
                            else
                            {
                                Console.WriteLine($"{item.Car} mileage decreased by {kilometers} kilometers");
                            }
                            break;
                        }
                    }
                }

                command = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var car in vechicles.OrderByDescending(x => x.Mileage).ThenBy(x => x.Car))
            {
                Console.WriteLine($"{car.Car} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}
