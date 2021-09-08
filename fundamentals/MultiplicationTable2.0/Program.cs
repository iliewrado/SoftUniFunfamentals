using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int integer = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int result = 0;
            
            if (multiplier > 10)
            {
                result = integer * multiplier;
                Console.WriteLine($"{integer} X {multiplier} = {result}");
            }
            for (int i = multiplier; i <= 10; i++)
            {
                result = integer * i;
                Console.WriteLine($"{integer} X {i} = {result}");
            }            
        }
    }
}
