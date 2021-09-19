using System;

namespace _08MathPower
{
    class mathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = PowerCalculator(number, power);
            
            Console.WriteLine(result);
            
            
        }
        static double PowerCalculator(double num, double pow)
        {
            double powered = 1;

            for (int i = 0; i < pow; i++)
            {
                powered *= num;
            }
            return powered;
        }
    }
}
