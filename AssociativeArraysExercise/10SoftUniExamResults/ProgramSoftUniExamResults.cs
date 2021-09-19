using System;
using System.Collections.Generic;
using System.Linq;

namespace _10SoftUniExamResults
{
    class ProgramSoftUniExamResults
    {
        static void Main(string[] args)
        {
            string usename = string.Empty;
            string language = string.Empty;
            int points = 0;
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> langueges = new Dictionary<string, int>();

            string[] input = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "exam finished")
            {
                usename = input[0];
                if (input.Length > 2)
                {
                    language = input[1];
                    points = int.Parse(input[2]);
                    if (students.ContainsKey(usename))
                    {
                        if (points > students[usename])
                        {
                            students[usename] = points;
                        }
                        langueges[language]++;
                    }
                    else
                    {
                        students.Add(usename, points);
                        if (langueges.ContainsKey(language))
                        {
                            langueges[language]++;
                        }
                        else
                        {
                            langueges.Add(language, 1);
                        }
                    }
                }
                else
                {
                    students.Remove(usename);
                }
                input = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("Results:");
            foreach (var item in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in langueges.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
