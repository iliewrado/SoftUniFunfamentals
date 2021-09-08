using System;

namespace _08TownInfo
{
    class townInfo
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double sqareArea = double.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {population} and area {sqareArea} square km.");
        }
    }
}
