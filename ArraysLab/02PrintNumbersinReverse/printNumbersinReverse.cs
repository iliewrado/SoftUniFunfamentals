﻿using System;
using System.Linq;

namespace _02PrintNumbersinReverse
{
    class printNumbersinReverse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', numbers.Reverse()));
        }
    }
}
