using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().ToUpper()
                .Split()
                .ToList();

            while (command[0] != "END")
            {
                int number = 0;
                int index = 0;

                switch (command[0])
                {
                    case "ADD":
                        numbers.Add(number = int.Parse(command[1]));
                        break;
                    case "REMOVE":
                        numbers.Remove(number = int.Parse(command[1]));
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(index = int.Parse(command[1]));
                        break;
                    case "INSERT":
                        numbers.Insert((index = int.Parse(command[2])), (number = int.Parse(command[1])));
                        break;
                }
                command = Console.ReadLine()
                   .ToUpper()
                   .Split()
                   .ToList(); ;
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
