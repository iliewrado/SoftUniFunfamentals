using System;
using System.Collections.Generic;
using System.Linq;

namespace test03
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                int rarity = int.Parse(info[1]);

                if (plants.ContainsKey(info[0]))
                {
                    plants[info[0]] = rarity;
                }
                else
                {
                    plants.Add(info[0], rarity);
                    plantRating.Add(info[0], new List<double>());
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] command = input
                    .Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = command[1];

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (command[0] == "Rate")
                {
                    double rating = double.Parse(command[2]);
                    plantRating[plant].Add(rating);
                }
                else if (command[0] == "Update")
                {
                    int rarity = int.Parse(command[2]);
                    plants[plant] = rarity;
                }
                else if (command[0] == "Reset")
                {
                    plantRating[plant] = new List<double>();
                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }
            }

            Dictionary<string, List<double>> exhibition = new Dictionary<string, List<double>>();

            foreach (var plant in plantRating.OrderByDescending(x => x.Value.Count > 0 ? x.Value.Average() : 0))
            {
                string name = plant.Key;
                double rarity = plants[name];
                double avarage = plant.Value.Count > 0 ? plant.Value.Average() : 0;


                exhibition[name] = new List<double>();
                exhibition[name].Add(avarage);
                exhibition[name].Add(rarity);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in exhibition.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[1]}; Rating: {item.Value[0]:f2}");
            }
        }
    }
}
