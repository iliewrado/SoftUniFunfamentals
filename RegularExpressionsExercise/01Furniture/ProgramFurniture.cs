using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01Furniture
{
    class ProgramFurniture
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sum = 0;
            string pattern = @">>([A-Za-z]+)<<([0-9\.0-9]+)!([0-9]+)";
            List<string> productName = new List<string>();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match collection = Regex.Match(input, pattern);
                if (collection.Length !=0)
                {
                    productName.Add(collection.Groups[1].Value);
                    sum += double.Parse(collection.Groups[2].Value) * double.Parse(collection.Groups[3].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in productName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
