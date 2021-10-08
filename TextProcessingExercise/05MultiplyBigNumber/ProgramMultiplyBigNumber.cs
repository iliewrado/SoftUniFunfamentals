using System;
using System.Linq;
using System.Text;

namespace _05MultiplyBigNumber
{
    class ProgramMultiplyBigNumber
    {
        static void Main(string[] args)
        {
            char[] bigInt = Console.ReadLine().Reverse().ToArray();
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                StringBuilder result = new StringBuilder();
                int add = 0;

                for (int i = 0; i < bigInt.Length; i++)
                {

                    int temp = ((bigInt[i] - 48) * n) + add;
                    int x = temp % 10;
                    add = temp / 10;
                    result.Append(x);
                }

                if (add > 0)
                {
                    result.Append(add);
                }

                string final = new string(result.ToString().Reverse().ToArray());

                Console.WriteLine(final);
            }
        }
    }
}
