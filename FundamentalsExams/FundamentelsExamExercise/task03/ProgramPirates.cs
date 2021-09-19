using System;
using System.Collections.Generic;
using System.Linq;

namespace task03
{
    class Island
    {
        public string Town { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public Island()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Island> islands = new List<Island>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] information = input
                    .Split(new char[] { '|', '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (islands.Exists(x => x.Town == information[0]))
                {
                    int index = islands.IndexOf(islands.Find(x => x.Town == information[0]));
                    islands[index].Population += int.Parse(information[1]);
                    islands[index].Gold += int.Parse(information[2]);
                }
                else
                {
                    Island island = new Island()
                    {
                        Town = information[0],
                        Population = int.Parse(information[1]),
                        Gold = int.Parse(information[2])
                    };
                    islands.Add(island);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input
                    .Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Plunder":
                        int index = islands.IndexOf(islands.Find(x => x.Town == command[1]));
                        islands[index].Population -= int.Parse(command[2]);
                        islands[index].Gold -= int.Parse(command[3]);
                        Console.WriteLine($"{islands[index].Town} plundered! {int.Parse(command[3])} gold stolen, {int.Parse(command[2])} citizens killed.");
                        if (islands[index].Population <= 0 || islands[index].Gold <= 0)
                        {
                            Console.WriteLine($"{islands[index].Town} has been wiped off the map!");
                            islands.RemoveAt(index);
                        }
                        break;
                    case "Prosper":
                        if (int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }
                        else
                        {
                            index = islands.IndexOf(islands.Find(x => x.Town == command[1]));
                            islands[index].Gold += int.Parse(command[2]);
                            Console.WriteLine($"{int.Parse(command[2])} gold added to the city treasury. {islands[index].Town} now has {islands[index].Gold} gold.");
                        }
                        break;
                }
            }

            if (islands.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {islands.Count} wealthy settlements to go to:");
                foreach (var item in islands.OrderByDescending(x => x.Gold).ThenBy(x => x.Town))
                {
                    Console.WriteLine($"{item.Town} -> Population: {item.Population} citizens, Gold: {item.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
