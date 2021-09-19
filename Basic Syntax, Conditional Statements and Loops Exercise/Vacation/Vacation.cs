using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {

            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayType = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;
            double discount = 0;

            if (groupType == "Students")
            {
                switch (dayType)
                {
                    case "Friday":
                        price = 8.45; break;
                    case "Saturday":
                        price = 9.80; break;
                    case "Sunday":
                        price = 10.46; break;
                }
                totalPrice = price * groupCount;
                if (groupCount >= 30)
                {
                    discount = totalPrice * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                switch (dayType)
                {
                    case "Friday":
                        price = 10.90; break;
                    case "Saturday":
                        price = 15.60; break;
                    case "Sunday":
                        price = 16; break;
                }
                totalPrice = price * groupCount;
                if (groupCount >= 100)
                {
                    discount = 10 * price;
                }
            }
            else if (groupType == "Regular")
            {
                switch (dayType)
                {
                    case "Friday":
                        price = 15; break;
                    case "Saturday":
                        price = 20; break;
                    case "Sunday":
                        price = 22.50; break;
                }
                totalPrice = price * groupCount;
                if (groupCount >= 10 && groupCount <=20)
                {
                    discount = totalPrice * 0.05;
                }
            }
            Console.WriteLine($"Total price: {(totalPrice - discount):f2}");
        }
    }
}
