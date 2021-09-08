using System;

namespace _08BeerKegs
{
    class beerKegs
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string bigestModel = string.Empty;
            double maxVolume = double.MinValue;
            for (int i = 0; i < counter; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = (Math.PI * (radius * radius)) * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    bigestModel = model;
                }
            }
            Console.WriteLine(bigestModel);
        }
    }
}
