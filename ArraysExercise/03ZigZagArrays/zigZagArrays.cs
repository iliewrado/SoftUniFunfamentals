using System;
using System.Linq;

namespace _03ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            int[] odd = new int[lines];
            int[] even = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    odd[i] = input[1];
                    even[i] = input[0];
                }
                else
                {
                    odd[i] = input[0];
                    even[i] = input[1];
                }
            }
            Console.WriteLine(string.Join(' ',odd));
            Console.WriteLine(string.Join(' ',even));
        }
    }
}