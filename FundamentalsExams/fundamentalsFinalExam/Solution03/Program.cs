using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> followers = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] command = input
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string name = command[1].Trim();

                switch (command[0])
                {
                    case "New follower":
                        if (!followers.ContainsKey(name))
                        {
                            followers.Add(name, 0);
                        }
                        break;
                    case "Like":
                        int count = int.Parse(command[2].Trim());
                        if (followers.ContainsKey(name))
                        {
                            followers[name] += count;
                        }
                        else
                        {
                            followers.Add(name, count);
                        }
                        break;
                    case "Comment":
                        if (followers.ContainsKey(name))
                        {
                            followers[name]++;
                        }
                        else
                        {
                            followers.Add(name, 1);
                        }
                        break;
                    case "Blocked":
                        if (followers.ContainsKey(name))
                        {
                            followers.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                        break;
                }
            }
            Console.WriteLine($"{followers.Count} followers");
            foreach (var follower in followers.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}
