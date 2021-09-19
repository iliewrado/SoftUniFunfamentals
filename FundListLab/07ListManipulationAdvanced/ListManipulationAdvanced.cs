using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().ToUpper()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            bool isChanget = false;

            while (command[0] != "END")
            {
                int number = 0;
                int index = 0;

                switch (command[0])
                {
                    case "ADD":
                        numbers.Add(number = int.Parse(command[1]));
                        isChanget = true;
                        break;
                    case "REMOVE":
                        numbers.Remove(number = int.Parse(command[1]));
                        isChanget = true;
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(index = int.Parse(command[1]));
                        isChanget = true;
                        break;
                    case "INSERT":
                        numbers.Insert((index = int.Parse(command[2])), (number = int.Parse(command[1])));
                        isChanget = true;
                        break;
                    case "CONTAINS":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(' ', numbers
                            .Where(n => n % 2 == 0)));
                        break;
                    case "PRINTODD":
                        Console.WriteLine(string.Join(' ', numbers
                            .Where(n => n % 2 != 0)));
                        break;
                    case "GETSUM":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "FILTER":
                        string result = string.Empty;
                        switch (command[1])
                        {
                            case "<":
                                result = string.Join(" ", numbers
                                    .Where(n => n < int.Parse(command[2])));
                                break;
                            case ">":
                                result = string.Join(" ", numbers
                                    .Where(n => n > int.Parse(command[2])));
                                break;
                            case ">=":
                                result = string.Join(" ", numbers
                                    .Where(n => n >= int.Parse(command[2])));
                                break;
                            case "<=":
                                result = string.Join(" ", numbers
                                    .Where(n => n <= int.Parse(command[2])));
                                break;
                        }
                        Console.WriteLine(result);
                        break;
                }
                command = Console.ReadLine()
                   .ToUpper()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
            }
            if (isChanget == true)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
