using System;

namespace _05SpecialNumbers
{
    class specialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digit = i;

                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }
                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
