using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05NetherRealms
{
    class ProgramNetherRealms
    {
        static void Main(string[] args)
        {
            string letterPattern = @"([^\d\+\-\/\*\.\s]+)";
            string digitPattern = @"([+-]*[0-9]+[\.]*\d*)";

            string[] names = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToArray();

            Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();

            int health = 0;
            double damage = 0;

            foreach (var name in names)
            {                
                MatchCollection digits = Regex.Matches(name, digitPattern);
                List<double> values = new List<double>();
                List<char> letter = new List<char>(Regex.Matches(name, letterPattern)
                    .Distinct()
                    .SelectMany(x => x.Value)
                    .ToList());                
                health = letter.Sum(x => x);
                damage = digits.Select(x => double.Parse(x.Value)).Sum();

                if (name.Contains('*') || name.Contains('/'))
                {
                    foreach (var i in name.Where(x => x == '*' || x == '/'))
                    {
                        if (i == '*')
                        {
                            damage *= 2;
                        }
                        if (i == '/')
                        {
                            damage /= 2;
                        }
                    }
                }

                values.Add(health);
                values.Add(damage);
                demons.Add(name, values);

            }
            foreach (var daemon in demons)
            {
                Console.WriteLine($"{daemon.Key} - {daemon.Value[0]} health, {(daemon.Value[1]):f2} damage");
            }
        }
    }
}
