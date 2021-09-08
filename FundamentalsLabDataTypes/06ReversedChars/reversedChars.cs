using System;

namespace _06ReversedChars
{
    class reversedChars
    {
        static void Main(string[] args)
        {
            char thirtChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char firstChar = char.Parse(Console.ReadLine());
            
            Console.WriteLine($"{firstChar} {secondChar} {thirtChar}");
        }
    }
}
