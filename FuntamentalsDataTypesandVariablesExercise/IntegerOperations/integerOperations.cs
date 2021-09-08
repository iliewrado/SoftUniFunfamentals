using System;

namespace IntegerOperations
{
    class integerOperations
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sumOfnumbers = firstNumber + secondNumber;
            int thirdNumber = int.Parse(Console.ReadLine());
            sumOfnumbers /= thirdNumber;
            int fourthNumber = int.Parse(Console.ReadLine());
            sumOfnumbers *= fourthNumber;
            Console.WriteLine(sumOfnumbers);
        }
    }
}
