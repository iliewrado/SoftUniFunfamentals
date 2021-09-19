using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace test02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)([A-Z]{1,}[A-Za-z]{2,})\1";

            string locations = Console.ReadLine();

            MatchCollection destinations = Regex.Matches(locations, pattern);
            List<string> destination = new List<string>();

            int points = 0;

            for (int i = 0; i < destinations.Count; i++)
            {
                points += destinations[i].Groups[2].Length;
                destination.Add(destinations[i].Groups[2].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destination)}");
            Console.WriteLine($"Travel Points: {points}");

        }
    }
}
