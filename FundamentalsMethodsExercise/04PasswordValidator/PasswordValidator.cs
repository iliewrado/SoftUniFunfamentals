using System;

namespace _04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PasswordValidator(input);
            
        }

        static void PasswordValidator(string input)
        {
            bool invalid = false;
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }

            if (!(isLettersAndDigits(input)))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (DugitCounter(input) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }

            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool isLettersAndDigits(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (!((currentChar >= 48 && currentChar <= 57) || 
                    (currentChar >= 65 && currentChar <= 90) || 
                    (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int DugitCounter(string input)
        {
            int counter = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
