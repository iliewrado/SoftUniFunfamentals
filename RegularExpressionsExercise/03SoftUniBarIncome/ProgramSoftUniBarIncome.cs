using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    class ProgramSoftUniBarIncome
    {
        static void Main(string[] args)
        {
            string pattern = @"[^|$%\.]*%([A-Z][a-z]+)%[^|$%\.]*<([\w]+)>[^|$%\.]*\|([0-9]+)\|[^|$%\.]*?([0-9]+\.*?[0-9]*)\$[^|$%\.]*";
            double totelIncome = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match purchase = Regex.Match(input, pattern);
                if (purchase.Length != 0)
                {
                    double amount = double.Parse(purchase.Groups[3].Value) * double.Parse(purchase.Groups[4].Value);
                    Console.WriteLine($"{purchase.Groups[1].Value}: {purchase.Groups[2].Value} - {amount:f2}");
                    totelIncome += amount;
                }
            }

            Console.WriteLine($"Total income: {totelIncome:f2}");
        }
    }
}
