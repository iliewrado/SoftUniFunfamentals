using System;
using System.Text;

namespace _05DigitsLettersAndOther
{
    class ProgramDigitsLettersAndOther
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //char[] letters = text.ToCharArray();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (var x in text)
            {
                if (x > 47 && x < 58)
                {
                    digits.Append(x);
                }
                else if (x > 96 && x < 123 || x > 64 && x < 91)
                {
                    letters.Append(x);
                }
                else
                {
                    other.Append(x);
                }

            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
