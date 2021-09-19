using System;

namespace _07.VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            double coins = 0;
            double amount = 0;
            double price = 0;

            while (command != "start")
            {
                coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    amount += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                
                command = Console.ReadLine().ToLower();
            }
            while (command != "end")
            {
                command = Console.ReadLine().ToLower();
                bool fail = false;

                switch (command)
                {
                    case "nuts":
                        price = 2.0; break;
                    case "water":
                        price = 0.7; break;
                    case "crisps":
                        price = 1.5; break;
                    case "soda":
                        price = 0.8; break;
                    case "coke":
                        price = 1.0; break;
                        break;
                    case "end": break;
                    
                    default:
                        Console.WriteLine("Invalid product");
                        fail = true;
                        break;
                        
                }
                if (command != "end" && amount < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (command != "end" && fail != true)
                {
                    Console.WriteLine($"Purchased {command}");
                    amount -= price;

                }

            }
            
            Console.WriteLine($"Change: {amount:f2}");
        }
    }
}
