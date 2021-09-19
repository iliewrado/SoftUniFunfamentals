using System;

namespace _05AddandSubtract
{
    class AddandSubtract
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int addet = Sum(num1, num2);

            int result = Subtract(num3, addet);

            Console.WriteLine(result);
        }

        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int Subtract(int num, int num1)
        {
           int result = num1 - num;
            return result;
        }
    }
}
