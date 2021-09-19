using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class ProgramMatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string phoneMach = @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}\b";
            string phones = Console.ReadLine();
            MatchCollection matchPhone = Regex.Matches(phones, phoneMach);
            string[] matched = matchPhone.Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
