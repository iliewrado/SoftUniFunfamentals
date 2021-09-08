using System;
using System.Numerics;

namespace _03ExactSumofRealNumbers
{
    class exactSumOfRealNumbers
    {
        public static int BigInteger { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal number = 0;
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
