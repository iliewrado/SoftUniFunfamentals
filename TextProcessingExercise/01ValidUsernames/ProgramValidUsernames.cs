using System;
using System.Linq;

namespace _01ValidUsernames
{
    class ProgramValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in input)
            {
                bool isTrue = false;
                foreach (var x in word)
                {
                    if (char.IsLetterOrDigit(x) || x == '-' || x == '_')
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }

                if (word.Length > 2 && word.Length < 17 && isTrue == true) 
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
