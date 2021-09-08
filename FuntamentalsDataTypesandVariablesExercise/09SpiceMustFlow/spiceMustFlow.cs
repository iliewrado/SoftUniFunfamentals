using System;

namespace _09SpiceMustFlow
{
    class spiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int consumption = 26;
            int totalSpice = 0;
            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    days++;
                    int spices = startingYield;
                    totalSpice += spices - consumption;
                    startingYield -= 10;
                }
                totalSpice -= consumption;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
