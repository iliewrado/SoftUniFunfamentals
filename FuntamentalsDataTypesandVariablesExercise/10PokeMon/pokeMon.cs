using System;

namespace _10PokeMon
{
    class pokeMon
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int initialPower = pokePower;
            int counter = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;

                if ((initialPower / 2) == pokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
