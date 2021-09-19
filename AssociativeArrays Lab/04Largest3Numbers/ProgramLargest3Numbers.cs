using System;
using System.Linq;

namespace _04Largest3Numbers
{
    class ProgramLargest3Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            if (numbers.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            else
            {
                Console.Write(string.Join(" ", numbers));
            }
        }
    }
}
