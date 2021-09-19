using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PriceCalculator(product, quantity);

        }

        static void PriceCalculator(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "snacks":
                    price = quantity * 2.00; break;
                case "water":
                    price = quantity * 1.00; break;
                case "coke":
                    price = quantity * 1.40; break;
                case "coffee":
                    price = quantity * 1.50; break;
            }

            Console.WriteLine($"{price:f2}");
        }

    }
}
