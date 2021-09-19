using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstLine.Count,secondLine.Count); i++)
            {
                result.Add(firstLine[i]);
                result.Add(secondLine[i]);
            }

            if (firstLine.Count < secondLine.Count)
            {
                result.AddRange(GetRemainingElements(firstLine, secondLine));
            }
            else
            {
                result.AddRange(GetRemainingElements(secondLine, firstLine));
            }


            Console.WriteLine(string.Join(' ', result));
        }
        static List<int> GetRemainingElements(List<int> shortOne, List<int> longOne)
        {
            List<int> list = new List<int>();
            for (int i = shortOne.Count; i < longOne.Count; i++)
            {
                list.Add(longOne[i]);
            }
            return list;
        }
    }
}
