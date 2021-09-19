using System;
using System.Linq;

namespace _08CondenseArraytoNumber
{
    class condenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            if (arrayOfNumbers.Length == 1)
            {
                Console.WriteLine(arrayOfNumbers[0]);
            }
            else
            {
                while (arrayOfNumbers.Length > 1)
                {
                    int[] condensed = new int[arrayOfNumbers.Length - 1];
                    for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
                    {
                        condensed[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];
                    }
                    arrayOfNumbers = condensed;
                }
                Console.WriteLine(arrayOfNumbers[0]);
            }
        }
    }
}
