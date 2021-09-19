using System;
using System.Text.RegularExpressions;

namespace _06ExtractEmails
{
    class ProgramExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)(?<user>[a-z0-9]+[.-]*\w*)*@(?<host>[a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))";

            string input = Console.ReadLine();

            MatchCollection maching = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(Environment.NewLine, maching));
        }
    }
}
