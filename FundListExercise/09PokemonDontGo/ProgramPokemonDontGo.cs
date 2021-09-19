using System;
using System.Collections.Generic;
using System.Linq;

namespace _09PokemonDontGo
{
    class ProgramPokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> pocemons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int curentDigit = 0;

            for (int i = 0; i < pocemons.Count; i++)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    curentDigit = pocemons[0];
                    sum += curentDigit;
                    pocemons.RemoveAt(0);
                    pocemons.Insert(0, pocemons[pocemons.Count - 1]);
                    
                }
                else if (index >= pocemons.Count)
                {
                    curentDigit = pocemons[pocemons.Count - 1];
                    sum += curentDigit;
                    pocemons.RemoveAt(pocemons.Count - 1);
                    pocemons.Add(pocemons[0]);
                }
                else
                {
                    curentDigit = pocemons[index];
                    sum += curentDigit;
                    pocemons.RemoveAt(index);
                }

                for (int j = 0; j < pocemons.Count; j++)
                {
                    if (pocemons[j] > curentDigit)
                    {
                        pocemons[j] -= curentDigit;
                    }
                    else
                    {
                        pocemons[j] += curentDigit;
                    }
                }

                i--;
            }
      
            Console.WriteLine(sum);
        }
    }
}
