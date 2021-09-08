using System;

namespace _10LowerorUpper
{
    class lowerOrUpper
    {
        static void Main(string[] args)
        {
            string symbol = (Console.ReadLine());
            if (symbol != symbol.ToLower())
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
