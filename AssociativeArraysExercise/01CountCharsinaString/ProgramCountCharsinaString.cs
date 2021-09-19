using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountCharsinaString
{
    class ProgramCountCharsinaString
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .SelectMany(x => x.Where(x => x != ' '))
                .ToList();
            
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (charCount.ContainsKey(letter))
                {
                    charCount[letter]++;
                }
                else
                {
                    charCount.Add(letter, 1);
                }
            }
            
            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
