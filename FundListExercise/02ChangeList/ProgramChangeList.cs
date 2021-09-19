using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class ProgramChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
