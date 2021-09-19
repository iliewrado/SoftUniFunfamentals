using System;

namespace PrintAndSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {

            int startNumb = int.Parse(Console.ReadLine());
            int endNumb = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startNumb; i <= endNumb; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
