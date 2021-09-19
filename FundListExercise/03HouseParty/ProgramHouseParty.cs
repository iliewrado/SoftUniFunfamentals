using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HouseParty
{
    class ProgramHouseParty
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
                
            List<string> guests = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                if (command[2] == "going!")
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else if (command[2] == "not")
                {
                    if (!guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(command[0]);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
