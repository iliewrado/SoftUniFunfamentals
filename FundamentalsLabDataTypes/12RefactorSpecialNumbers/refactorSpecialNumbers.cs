using System;

namespace _12RefactorSpecialNumbers
{
    class refactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;

            for (int h = 1; h <= num; h++)
            {
                number = h;
                while (h > 0)
                {
                    sum += h % 10;
                    h = h / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                sum = 0;
                h = number;
            }
        }
    }
}
