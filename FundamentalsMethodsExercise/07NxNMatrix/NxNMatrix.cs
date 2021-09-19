using System;

namespace _07NxNMatrix
{
    class NxNMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NNMatrix(n);
        }

        static void NNMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
