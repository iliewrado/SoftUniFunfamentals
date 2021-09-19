using System;
using System.Collections.Generic;
using System.Linq;

namespace problem03
{
    class Hero
    {
        public string Name { get; set; }
        public int HitPower { get; set; }
        public int Mana { get; set; }
        public Hero()
        {


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < count; i++)
            {
                Hero hero = new Hero();
                string[] info = ReadArrayConsole();

                string name = info[0];
                int hitPoints = int.Parse(info[1]);
                int manaPoints = int.Parse(info[2]);

                hero.Name = name;
                hero.HitPower = hitPoints;
                hero.Mana = manaPoints;

                for (int j = 0; j < heroes.Count; j++)
                {
                    if (heroes[j].Name.Contains(name))
                    {
                        heroes[j].Mana = manaPoints;
                        heroes[j].HitPower = hitPoints;
                    }
                }
                if (!heroes.Contains(hero))
                {
                    heroes.Add(hero);
                }
            }

            string[] command = ReadArrayConsole();

            while (command[0] != "End")
            {
                string name = command[1];

                if (command[0] == "CastSpell")
                {
                    int mana = int.Parse(command[2]);
                    string spell = command[3];

                    foreach (var hero in heroes)
                    {
                        if (hero.Name.Contains(name))
                        {
                            if (hero.Mana >= mana)
                            {
                                hero.Mana -= mana;
                                Console.WriteLine($"{hero.Name} has successfully cast {spell} and now has {hero.Mana} MP!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{hero.Name} does not have enough MP to cast {spell}!");
                                break;
                            }
                        }
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];
                    foreach (var hero in heroes)
                    {
                        if (hero.Name.Contains(name))
                        {
                            hero.HitPower -= damage;
                            if (hero.HitPower > 0)
                            {
                                Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HitPower} HP left!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                                heroes.Remove(hero);
                                break;
                            }
                        }
                    }
                }
                else if (command[0] == "Recharge")
                {
                    int amount = int.Parse(command[2]);
                    foreach (var hero in heroes)
                    {
                        if (hero.Name.Contains(name))
                        {
                            if (hero.Mana + amount > 200)
                            {
                                amount = 200 - hero.Mana;
                                hero.Mana = 200;
                            }
                            else
                            {
                                hero.Mana += amount;
                            }
                            Console.WriteLine($"{hero.Name} recharged for {amount} MP!");
                            break;
                        }
                    }
                }
                else if (command[0] == "Heal")
                {
                    int hp = int.Parse(command[2]);
                    foreach (var her in heroes)
                    {
                        if (her.Name.Contains(name))
                        {
                            if (her.HitPower + hp > 100)
                            {
                                hp = 100 - her.HitPower;
                                her.HitPower = 100;
                            }
                            else
                            {
                                her.HitPower += hp;
                            }
                            Console.WriteLine($"{her.Name} healed for {hp} HP!");
                            break;
                        }
                    }
                }

                command = ReadArrayConsole();
            }

            foreach (var hero in heroes.OrderByDescending(x => x.HitPower).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.HitPower}");
                Console.WriteLine($"  MP: {hero.Mana}");
            }
        }
        static string[] ReadArrayConsole()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '-' }, StringSplitOptions
                .RemoveEmptyEntries);
            return input;
        }
    }
}
