using System;
using System.Linq;

namespace _08LettersChangeNumbers
{
    class ProgramLettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                string temp = string.Empty;
                int position = 0;
                double result = 0;
                for (int i = 1; i < item.Length - 1; i++)
                {
                    temp += item[i];
                }
                double digit = double.Parse(temp);
                if (firstLetter > 64 && firstLetter < 91)
                {
                    position = firstLetter - 64;
                    result = digit / position;
                }
                else
                {
                    position = firstLetter - 96;
                    result = digit * position;
                }
                if (lastLetter > 64 && lastLetter < 91)
                {
                    position = lastLetter - 64;
                    result -= position;
                }
                else
                {
                    position = lastLetter - 96;
                    result += position;
                }
                sum += result;

            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
