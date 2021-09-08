using System;

namespace _02PoundstoDollars
{
    class poundstoDollars
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollar = pounds * 1.31M;

            Console.WriteLine($"{dollar:F3}");
        }
    }
}
