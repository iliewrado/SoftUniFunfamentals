using System;
using System.Collections.Generic;

namespace _05SoftUniParking
{
    class ProgramSoftUniParking
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string key = input[1];
                
                if (command == "register")
                {
                    string value = input[2];

                    if (parking.ContainsKey(key))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {value}");
                    }
                    else
                    {
                        parking.Add(key, value);
                        Console.WriteLine($"{key} registered {value} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (parking.ContainsKey(key))
                    {
                        parking.Remove(key);
                        Console.WriteLine($"{key} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {key} not found");
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
