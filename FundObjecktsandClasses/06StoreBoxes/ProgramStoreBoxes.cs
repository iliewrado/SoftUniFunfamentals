using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double Price { get; set; }
    }
    class ProgramStoreBoxes
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<Box> box = new List<Box>();

            while (items[0] != "end")
            {
                string serialNumber = items[0];
                string itemName = items[1];
                int qty = int.Parse(items[2]);
                double price = double.Parse(items[3]);

                Box boxes = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemName = itemName,
                    Quantity = qty,
                    Price = price,
                    TotalPrice = price * qty
                };
                box.Add(boxes);

                items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            List<Box> final = new List<Box>(box.OrderByDescending(x => x.TotalPrice));

            foreach (Box item in final)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.ItemName} - ${item.Price:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.TotalPrice:f2}");
            }
        }
    }
}
