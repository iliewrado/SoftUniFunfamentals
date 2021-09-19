using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class ProgramMatchFullName
    {
        static void Main(string[] args)
        {
            string nameReg = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection machNames = Regex.Matches(names, nameReg);
            foreach (Match name in machNames)
            {
                Console.Write($"{name.Value} ");
            }
            Console.WriteLine();
        }
    }
}
