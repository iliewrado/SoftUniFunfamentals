using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arrayInput.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arrayInput[j];
                }
                for (int k = i + 1; k < arrayInput.Length; k++)
                {
                    rightSum += arrayInput[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
