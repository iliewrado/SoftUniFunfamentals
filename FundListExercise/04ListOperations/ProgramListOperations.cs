using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListOperations
{
    class ProgramListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int number = 0;
                int index = 0;
                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        if (index >= numbers.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, number);
                        }
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        if (index >= numbers.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(index);
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int first = numbers[0];
                                numbers.Add(first);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int last = numbers[numbers.Count - 1];
                                numbers.Insert(0, last);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
