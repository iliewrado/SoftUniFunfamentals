using System;

namespace _09CharsToString
{
    class charsToString
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char thirt = char.Parse(Console.ReadLine());
            
            Console.WriteLine($"{first}{second}{thirt}");
        }
    }
}
