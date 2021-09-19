using System;

namespace _06.StrongNumber
{
    class Strongnumber
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            string equivelent = number.ToString();

            int sum = 1;
            int sumOfAll = 0;


            for (int i = 0; i < equivelent.Length; i++)
            {
                char digit = equivelent[i];
                int num = digit - 48;

                for (int j = num ; j > 0; j--)
                {
                    sum *= j;
                    
                }
                sumOfAll += sum;
                sum = 1;
            }
            if (sumOfAll == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
