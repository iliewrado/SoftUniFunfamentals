using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNumbers
{
    class ProgramBombNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bomber = bombInfo[0];
            int power = bombInfo[1];
            int index = list.IndexOf(bomber);

            while (index != -1)
            {
                int left = index - power;
                int right = index + power;

                if (left < 0)
                {
                    left = 0;
                }
                if (right > list.Count - 1)
                {
                    right = list.Count - 1;
                }

                list.RemoveRange(left, right - left + 1);

                index = list.IndexOf(bomber);
            }
            int sum = list.Sum();
            Console.WriteLine(sum);
        }
    }
}
