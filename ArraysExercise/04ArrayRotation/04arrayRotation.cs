using System;
using System.Linq;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int firstElement = array[0];
                int[] temp = new int[array.Length];
                
                for (int j = 1; j < array.Length; j++)
                {
                    temp[j - 1] = array[j];
                }
                temp[temp.Length - 1] = firstElement;
                array = temp;
            }
            
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
