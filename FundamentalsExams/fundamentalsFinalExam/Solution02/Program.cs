using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Solution02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\!([A-Z][a-z]{3,})\!(\:)\[([A-Za-z]{8,})\]";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match matches = Regex.Match(input, pattern);

                if (matches.Length > 0)
                {
                    string command = new string(matches.Groups[1].Value);
                    command += matches.Groups[2].Value;
                    List<int> charNumbers = new List<int>();
                    foreach (var letter in matches.Groups[3].Value)
                    {
                        charNumbers.Add(letter);
                    }
                    Console.WriteLine($"{command +" "}{string.Join(' ', charNumbers)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
