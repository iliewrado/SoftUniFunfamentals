using System;
using System.Linq;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int curentIndex = initialIndexes[i];
                if (curentIndex >= 0 && curentIndex < field.Length)
                {
                field[curentIndex] = 1;
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] elements = input.Split();
                int ladiBugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flayLength = int.Parse(elements[2]);
                if (ladiBugIndex < 0 
                    || ladiBugIndex > field.Length- 1
                    || field[ladiBugIndex] == 0)
                {
                    continue;
                }

                field[ladiBugIndex] = 0;
                if (direction == "right")
                {
                    int landIndex = ladiBugIndex + flayLength;
                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flayLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex < field.Length)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladiBugIndex - flayLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flayLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex < field.Length)
                    {
                    field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(' ',field));
        }
    }
}
