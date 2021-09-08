using System;

namespace _11RefactorVolumeofPyramid
{
    class refactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (Length * Width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
