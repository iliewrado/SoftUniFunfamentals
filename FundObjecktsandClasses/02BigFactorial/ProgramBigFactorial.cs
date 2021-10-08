﻿using System;
using System.Numerics;

namespace _02BigFactorial
{
    class ProgramBigFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
