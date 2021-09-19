using System;

namespace _11MathOperations
{
    class mathOperations
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculator(firstNumber, operation, secondNumber);

            Console.WriteLine(result);
        }

        static double Calculator(double numb1, string operation, double numb2)
        {
            double result = 0;
            switch (operation)
            {
                case "/":
                    result = numb1 / numb2; break;
                case "*":
                    result = numb1 * numb2; break;
                case "+":
                    result = numb1 + numb2; break;
                case "-":
                    result = numb1 - numb2;
                    break;
            }
            return result;
        }
    
    }
}
