using System;

namespace _10MultiplyEvensbyOdds
{
    class multiplyEvensbyOdds
    {
        static void Main(string[] args)
        {

            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultiple(number);

            Console.WriteLine(result);
        }

        static int GetMultiple(int number)
        {
            int currentDigit = 0;
            int evenSum = 0;
            int oddSum = 0;

            while (number > 0)
            {
                currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    oddSum += currentDigit;
                }
                else
                {
                    evenSum += currentDigit;
                }
                number /= 10;

            }
            int multiple = evenSum * oddSum;
            return multiple;

        }
    }
}
