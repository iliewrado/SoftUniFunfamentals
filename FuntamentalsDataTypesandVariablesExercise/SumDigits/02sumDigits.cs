using System;

namespace SumDigits
{
    class sumDigits
    {
        static void Main(string[] args)
        {
            string integer = Console.ReadLine();
            int sum = 0;
            int number = int.Parse(integer);
            for (int i = 0; i < integer.Length; i++)
            {
                sum += number % 10;
                number = number / 10;
                if (number == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
