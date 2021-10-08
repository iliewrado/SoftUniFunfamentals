using System;
using System.Linq;

namespace _02CharacterMultiplier
{
    class ProgramCharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int result = CharMultiplaer(input[0], input[1]);
            
            Console.WriteLine(result);
        }
        static int CharMultiplaer(string first, string second)
        {
            int sum = 0;
            int count = Math.Min(first.Length, second.Length);
            for (int i = 0; i < count; i++)
            {
                sum += first[i] * second[i];
            }
            if (count < first.Length)
            {
                for (int i = count; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else
            {
                for (int i = count; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            return sum;
        }
    }
}
