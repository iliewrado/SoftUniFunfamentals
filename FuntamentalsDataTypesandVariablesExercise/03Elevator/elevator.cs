using System;

namespace _03Elevator
{
    class elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int cources = (int)Math.Ceiling((double)people / capacity);
            
            Console.WriteLine(cources);
        }
    }
}
