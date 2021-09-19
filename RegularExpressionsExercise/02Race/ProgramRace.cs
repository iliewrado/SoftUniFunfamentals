using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02Race
{
    class ProgramRace
    {
        static void Main(string[] args)
        {
            string letterPattern = @"([A-Za-z]+)";
            string digitPattern = @"([0-9])";
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = string.Empty;
            Dictionary<string, double> racers = new Dictionary<string, double>();

            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection letterReg = Regex.Matches(input, letterPattern);
                MatchCollection digitReg = Regex.Matches(input, digitPattern);

                string racer = String.Concat(letterReg);
                double distance = digitReg.Select(x => double.Parse(x.Value)).Sum();

                if (participants.Contains(racer))
                {
                    if (racers.ContainsKey(racer))
                    {
                        racers[racer] += distance;
                    }
                    else
                    {
                        racers.Add(racer, distance);
                    }
                }
            }
            string[] n = racers.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToArray();
            Console.WriteLine("1st place: " + n[0]);
            Console.WriteLine("2nd place: " + n[1]);
            Console.WriteLine("3rd place: " + n[2]);

        }
        
    }
}
