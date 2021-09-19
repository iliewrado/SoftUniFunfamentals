using System;
using System.Collections.Generic;

namespace _04Orders
{
    class ProgramOrders
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, double> price = new Dictionary<string, double>();
            Dictionary<string, int> quantity = new Dictionary<string, int>();

            while (command[0] != "buy")
            {
                string name = command[0];
                double prices = double.Parse(command[1]);
                int qty = int.Parse(command[2]);

                if (price.ContainsKey(name) && quantity.ContainsKey(name))
                {
                    price[name] = prices;
                    quantity[name] += qty;
                }
                else
                {
                    price.Add(name, prices);
                    quantity.Add(name, qty);
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in quantity)
            {
                if (price.ContainsKey(item.Key))
                {
                    price[item.Key] *= item.Value;
                }
            }
            foreach (var item in price)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
