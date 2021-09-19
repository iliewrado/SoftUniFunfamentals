using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace task02
{
    class ProgramEmojiDetector
    {
        static void Main(string[] args)
        {
            string emogiPattern = @"(\:{2}|\*{2})([A-Z]{1}[a-z]{2,})\1";
            string digitPattern = @"\d";

            string input = Console.ReadLine();

            MatchCollection digits = Regex.Matches(input, digitPattern);
            BigInteger coolness = 1;
            foreach (Match i in digits)
            {
                coolness *= int.Parse(i.Value);
            }

            MatchCollection emogies = Regex.Matches(input, emogiPattern);
            int count = emogies.Count;
            List<string> words = new List<string>();

            for (int i = 0; i < count; i++)
            {
                words.Add(emogies[i].Groups[2].Value);
            }

            List<string> valid = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                BigInteger sum = new List<char>(words[i]).Sum(x => x);
                if (sum >= coolness)
                {
                    valid.Add(emogies[i].Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolness}");
            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            if (count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, valid));
            }
        }
    }
}
