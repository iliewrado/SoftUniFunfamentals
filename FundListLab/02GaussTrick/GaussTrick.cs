using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GaussTrick
{
    class GaussTrick
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int lentgh = numbers.Count;

            for (int i = 0; i < (lentgh / 2); i++)
            {
                numbers[i] += numbers[numbers.Count -1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
