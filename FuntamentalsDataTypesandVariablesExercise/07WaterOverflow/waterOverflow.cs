using System;

namespace _07WaterOverflow
{
    class waterOverflow
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int tankCapacity = 255;

            for (int i = 0; i < counter; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                
                if (liters > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankCapacity -= liters;
                }
            }
            Console.WriteLine(255 - tankCapacity);
        }
    }
}
