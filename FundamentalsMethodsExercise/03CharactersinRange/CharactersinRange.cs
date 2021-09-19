using System;

namespace _03CharactersinRange
{
    class CharactersinRange
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharPrinter(first, end);
        }

        static void CharPrinter(char start, char end)
        {
            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
