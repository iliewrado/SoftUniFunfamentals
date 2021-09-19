using System;

namespace _08FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = FindFactorial(num1) / FindFactorial(num2);

            Console.WriteLine($"{result:f2}");
        }

        static decimal FindFactorial(int num)
        {
            decimal fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
