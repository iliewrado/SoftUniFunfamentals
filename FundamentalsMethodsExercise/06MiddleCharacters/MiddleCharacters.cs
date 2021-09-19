using System;

namespace _06MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            FindMiddleChar(input);
        }

        static void FindMiddleChar(string text)
        {
            int i = text.Length / 2;
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[i-1]}{text[i]}");
            }
            else
            {
                Console.WriteLine(text[i]);
            }

        }
    }
}
