using System;
using System.Linq;

namespace _07StringExplosion
{
    class ProgramStringExplosion
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int power = input[i + 1] - 48;
                    string sub = input.Substring(i + 1, power);
                    if (sub.Contains('>'))
                    {
                        int index = sub.IndexOf('>');
                        input = input.Remove(i + 1, power - index);
                        power -= power - index;
                        power += input[i + sub.Length] - 48;
                        input = input.Remove(i+sub.Length, power);
                        i++;
                    }
                    else
                    {
                        input = input.Remove(i + 1, power);
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
