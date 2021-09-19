using System;

namespace _04PrintingTriangle
{
    class printingTriangle
    {
        static void Main(string[] args)
        {
            int ending = int.Parse(Console.ReadLine());

            TrianglePrinter(1, ending);

            static void TrianglePrinter(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

                for (int i = end - 1; i >= start; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
