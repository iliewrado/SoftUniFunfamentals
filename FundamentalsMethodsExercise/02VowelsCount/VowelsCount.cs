using System;
using System.Linq;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            int vowels = VowelsCounter(text);
            
            Console.WriteLine(vowels);
        }

        static int VowelsCounter(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'u': 
                    case 'e':
                    case 'i':
                    case 'o':
                    counter++; break;
                    default:
                        break;
                }
            }
            return counter;
        }
    }
}
