using System;

namespace _03Calculations
{
    class calculations
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine().ToLower();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    AddNumbers(firstNum, secondNum); break;
                case "multiply":
                    MultiplyNumbres(firstNum, secondNum); break;
                case "subtract":
                    SubstractNumbers(firstNum, secondNum); break;
                case "divide":
                    DevideNumbers(firstNum, secondNum); break;
            }

            static void AddNumbers(int number1, int number2)
            {
                Console.WriteLine(number1 + number2);
            }

            static void MultiplyNumbres(int number1, int number2)
            {
                Console.WriteLine(number1 * number2);
            }

            static void SubstractNumbers(int number1, int number2)
            {
                Console.WriteLine(number1 - number2);
            }

            static void DevideNumbers(int number1, int number2)
            {
                Console.WriteLine(number1 / number2);
            }
        }
    }
}
