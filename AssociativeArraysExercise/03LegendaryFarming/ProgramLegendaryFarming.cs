using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarming
{
    class ProgramLegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resouces = new Dictionary<string, int>();
            resouces.Add("fragments", 0);
            resouces.Add("shards", 0);
            resouces.Add("motes", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isFound = false;

            while (isFound != true)
            {
                List<string> items = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                for (int i = 0; i < items.Count; i += 2)
                {
                    string key = items[i + 1];
                    int value = int.Parse(items[i]);
                    if (key != "motes" && key != "shards" && key != "fragments")
                    {
                        if (junk.ContainsKey(key))
                        {
                            junk[key] += value;
                        }
                        else
                        {
                            junk.Add(key, value);
                        }
                    }
                    else
                    {
                        resouces[key] += value;
                    }

                    if (resouces["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        isFound = true;
                        resouces["motes"] -= 250;
                        break;
                    }
                    else if (resouces["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        isFound = true;
                        resouces["fragments"] -= 250;
                        break;
                    }
                    else if (resouces["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        isFound = true;
                        resouces["shards"] -= 250;
                        break;
                    }
                }
            }

            foreach (var item in resouces.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
