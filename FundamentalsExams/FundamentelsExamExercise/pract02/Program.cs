using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace pract02
{
    class Program
    {
        class Astra
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public int Calories { get; set; }
            public Astra()
            {

            }
        }
        static void Main(string[] args)
        {
            string pattern = @"(\#|\|)([A-Z\sa-z]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d+)\1";
            string information = Console.ReadLine();

            MatchCollection products = Regex.Matches(information, pattern);
            List<Astra> foodList = new List<Astra>();
            int calories = 0;

            foreach (var product in products)
            {
                string[] temp = product
                    .ToString()
                    .Split(new char[] { '|', '#' }, StringSplitOptions.RemoveEmptyEntries);
                calories += int.Parse(temp[2]);
                Astra foods = new Astra()
                {
                    Name = temp[0],
                    Date = temp[1],
                    Calories = int.Parse(temp[2])
                };

                foodList.Add(foods);
            }

            int totalCalories = calories / 2000;

            Console.WriteLine($"You have food to last you for: {totalCalories} days!");
            foreach (var food in foodList)
            {
                Console.WriteLine($"Item: {food.Name}, Best before: {food.Date}, Nutrition: {food.Calories}");
            }

        }
    }
}
