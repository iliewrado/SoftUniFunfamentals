using System;
using System.Linq;

namespace _03ReverseArrayofStrings
{
    class reverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(' ',Console.ReadLine().Split().Reverse()));


            //int[] array = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //четене от конзолата на масив от числа.
        }
    }
}
