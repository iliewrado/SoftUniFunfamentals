using System;
using System.Linq;

namespace _07EqualArrays
{
    class equalArrays
    {
        static void Main(string[] args)
        {
            int[] firstArrey = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArrey = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int arraySum = 0;
            bool isEqual = false;

            for (int i = 0; i < firstArrey.Length; i++)
            {
                if (firstArrey[i] != secondArrey[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isEqual = false;
                    break;
                }
                else
                {
                    arraySum += firstArrey[i];
                    isEqual = true;
                }
            }
            if (isEqual == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
            }
        }
    }
}
