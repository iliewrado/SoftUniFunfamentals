using System;
using System.Text.RegularExpressions;

namespace _03MatchDates
{
    class ProgramMatchDates
    {
        static void Main(string[] args)
        {
            string regularEx = @"(?<day>\d{2})(\/|-|.)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})";
            string dates = Console.ReadLine();
            MatchCollection match = Regex.Matches(dates, regularEx);
            
            foreach (Match date in match)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
