using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04StarEnigma
{
    class ProgramStarEnigma
    {
        static void Main(string[] args)
        {
            string pattern = @"[^@\-!:>]*@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(A|D)![^@\-!:>]*->(\d+)[^@\-!:>]*";
            string starCount = @"[sStTaArR]";
            List<string> attacked = new List<string>();
            List<string> destroied = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                MatchCollection tocount = Regex.Matches(message, starCount);
                int count = tocount.Count;
                
                string decript = string.Empty;
                foreach (var l in message)
                {
                    decript += ((char)(l - count)).ToString();
                }

                Match decrypting = Regex.Match(decript, pattern);

                if (decrypting.Groups["attack"].Value == "A")
                {
                    attacked.Add(decrypting.Groups["planet"].Value);
                }
                else if(decrypting.Groups["attack"].Value == "D")
                {
                    destroied.Add(decrypting.Groups["planet"].Value);
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count > 0)
            {
                foreach (var i in attacked.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {i}");
                }
            }
            
            Console.WriteLine($"Destroyed planets: {destroied.Count}");
            if (destroied.Count > 0)
            {
                foreach (var i in destroied.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {i}");
                }
            }
        }
    }
}
