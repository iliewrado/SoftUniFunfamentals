using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@\#+[A-Z]{1}[A-Za-z\d]{4,}[A-Z]{1}\@\#+";
            string digitPattern = @"\d";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Length > 0)
                {
                    MatchCollection group = Regex.Matches(input, digitPattern);
                    if (group.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", group)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
