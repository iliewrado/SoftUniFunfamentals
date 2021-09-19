using System;

namespace _06CalculateRectangleArea
{
    class calculateRectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = RectangleCalculator(width, height);

            Console.WriteLine(area);
        }

        static double RectangleCalculator(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
}
