using System;

namespace _05PrintPartOfASCIITable
{
    class printPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            for (int i = startNum; i <= endNum; i++)
            {
                char letter = (char)i;
                Console.Write($"{letter} ");
            }
            
            
        }
    }
}
