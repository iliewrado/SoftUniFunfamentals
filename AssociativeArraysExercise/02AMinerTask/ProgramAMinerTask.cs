using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    class ProgramAMinerTask
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<string> items = new List<string>();

            while ((input = Console.ReadLine()) != "stop")
            {
                items.Add(input);
            }

            Dictionary<string, int> resources = new Dictionary<string, int>();

            for (int i = 0; i < items.Count; i += 2)
            {
                if (resources.ContainsKey(items[i]))
                {
                    resources[items[i]] += int.Parse(items[i + 1]);
                }
                else
                {
                    resources.Add(items[i], int.Parse(items[i + 1]));
                }
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
