using System;
using System.Text;

namespace _04CaesarCipher
{
    class ProgramCaesarCipher
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] encription = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encription[i] = (char)(text[i] + 3);
            }

            string encripted = new string(encription);

            Console.WriteLine(encripted);
        }
    }
}
