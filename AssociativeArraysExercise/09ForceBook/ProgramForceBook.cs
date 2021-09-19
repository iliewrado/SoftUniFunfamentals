using System;
using System.Collections.Generic;
using System.Linq;

namespace _09ForceBook
{
    class ProgramForceBook
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            Dictionary<string, string> forceUsers = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splited = input.Split(" | ");
                    string forseSide = splited[0];
                    string forceUser = splited[1];
                    
                    if (forceUsers.ContainsKey(forceUser))
                    {
                        continue;
                    }

                    if (!forceSides.ContainsKey(forseSide))
                    {
                        forceSides.Add(forseSide, new List<string>());
                    }

                    forceSides[forseSide].Add(forceUser);
                    forceUsers.Add(forceUser, forseSide);
                    
                }
                else if (input.Contains("->"))
                {
                    input.Split(" -> ");
                    string[] splited = input.Split(" -> ");
                    string forceUser = splited[0];
                    string forseSide = splited[1];
                    
                    if (!forceSides.ContainsKey(forseSide))
                    {
                        forceSides.Add(forseSide, new List<string>());
                    }
                    if (forceUsers.ContainsKey(forceUser))
                    {
                        string oldSide = forceUsers[forceUser];
                        forceSides[oldSide].Remove(forceUser);
                        forceSides[forseSide].Add(forceUser);
                        forceUsers[forceUser] = forseSide;
                    }
                    else
                    {
                        forceSides[forseSide].Add(forceUser);
                        forceUsers.Add(forceUser, forseSide);
                    }

                    Console.WriteLine($"{forceUser} joins the {forseSide} side!");
                }
                
            }

            foreach (var item in forceSides.Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}
