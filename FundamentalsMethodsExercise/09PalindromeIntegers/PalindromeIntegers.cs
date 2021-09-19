using System;
using System.Linq;

namespace _09PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string input)
        {
            char[] reverse = input.Reverse().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!(reverse[i] == input[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
