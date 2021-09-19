using System;

namespace _01SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = NumCompare(num1, num2, num3);
            
            Console.WriteLine(result);
        }

        static int NumCompare(int num1, int num2, int num3)
        {
            int result = 0;

            if (num1 <= num2 && num1 <= num3)
            {
                return result = num1;
            }
            else if (num2 <= num3 && num2 <= num1)
            {
                return result = num2;
            }
            else if(num3 <= num1 && num3 <= num2)
            {
                return result = num3;
            }
            else
            {
                return result;
            }

        }
    }
}
