using System;
using System.Linq;

namespace _08MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];
                    if (sum == num)
                    {
                        Console.Write(string.Join(' ',array[i],array[j]));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
