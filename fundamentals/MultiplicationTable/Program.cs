using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int integer = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result = i * integer;
                Console.WriteLine($"{integer} X {i} = {result}");

            }
        }
    }
}
