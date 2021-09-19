using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    class sumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 == 0)
                {
                    sum += arrayNumbers[i];
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}
