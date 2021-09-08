﻿using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = int.Parse(Console.ReadLine());

            while (evenNumber % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                evenNumber = int.Parse(Console.ReadLine());
            }
            
            if (evenNumber % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");
            }
        }
    }
}
