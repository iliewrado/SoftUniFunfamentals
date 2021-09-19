using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthDna = int.Parse(Console.ReadLine());
            int[] bestDnaSample = new int[lengthDna];
            int bestDnaLength = 1;
            int bestStartIndex = 0;
            int bestSum = 0;
            int couter = 0;
            int bestSiquence = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                couter++;
                int length = 1;
                int bestlength = 1;
                int start = 0;
                int curentSum = 0;
                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == dna[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (length > bestlength)
                    {
                        bestlength = length;
                        start = i;
                    }
                    curentSum += dna[i];
                }
                curentSum += dna[lengthDna - 1];
                if (bestlength > bestDnaLength)
                {
                    bestDnaLength = bestlength;
                    bestStartIndex = start;
                    bestSum = curentSum;
                    bestSiquence = couter;
                    bestDnaSample = dna.ToArray();
                }
                else if (bestlength == bestDnaLength)
                {
                    if (start < bestStartIndex)
                    {
                        bestDnaLength = bestlength;
                        bestStartIndex = start;
                        bestSum = curentSum;
                        bestSiquence = couter;
                        bestDnaSample = dna.ToArray();
                    }
                    else if (start == bestStartIndex)
                    {
                        if (curentSum > bestSum)
                        {
                            bestDnaLength = bestlength;
                            bestStartIndex = start;
                            bestSum = curentSum;
                            bestSiquence = couter;
                            bestDnaSample = dna.ToArray();
                        }
                    }
                }    
            }
            Console.WriteLine($"Best DNA sample {bestSiquence} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestDnaSample));
        }
    }
}
