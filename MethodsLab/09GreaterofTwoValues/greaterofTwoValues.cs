using System;

namespace _09GreaterofTwoValues
{
    class greaterofTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            string result = string.Empty;
            if (type == "int")
            {
                int firstNum = int.Parse(firstText);
                int secondNum = int.Parse(secondText);

                result = GetMax(firstNum, secondNum).ToString();

            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstText);
                char secondChar = char.Parse(secondText);

                result = GetMax(firstChar, secondChar).ToString();

            }
            else
            {
                result = GetMax(firstText, secondText);
            }

            Console.WriteLine(result);
        }

        static int GetMax(int num1, int num2)
        {
            int result = int.MinValue;
            if (num1 > result)
            {
                result = num1;
            }
            if (num2 > num1)
            {
                result = num2;
            }
            return result;
        }
        static char GetMax(char letter1, char letter2)
        {
            char result = ' ';

            if (letter1 > letter2)
            {
                result = letter1;
            }
            else
            {
                result = letter2;
            }
            return result;
        }

        static string GetMax(string first, string second)
        {
            string result = string.Empty;

            if (first.CompareTo(second) > 0)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }

    }
}
