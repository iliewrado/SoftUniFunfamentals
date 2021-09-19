using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace solution02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@|\#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";

            string input = Console.ReadLine();

            MatchCollection words = Regex.Matches(input, pattern);

            List<string> word = new List<string>();
            List<string> mirror = new List<string>();
            List<string> reversed = new List<string>();
            Dictionary<string, string> matches = new Dictionary<string, string>();

            if (words.Count > 0)
            {
                foreach (var match in words)
                {
                    string[] temporary = match.ToString()
                        .Split(new char[] { '@', '#' }, StringSplitOptions.RemoveEmptyEntries);
                    char[] reverse = temporary[1].Reverse().ToArray();
                    word.Add(temporary[0]);
                    mirror.Add(temporary[1]);
                    reversed.Add(new string(reverse));
                }

                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == reversed[i])
                    {
                        matches.Add(word[i], mirror[i]);
                    }
                }

                Console.WriteLine($"{words.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (matches.Count > 0)
            {
                Console.WriteLine("The mirror words are:");

                Console.Write(string.Join(", ", matches.Select(x => x.Key + " <=> " + x.Value)));

            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
