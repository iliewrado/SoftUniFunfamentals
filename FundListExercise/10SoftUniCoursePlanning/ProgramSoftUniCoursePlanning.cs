using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10SoftUniCoursePlanning
{
    class ProgramSoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (commands[0] != "course start")
            {
                if (commands[0] == "Add")
                {
                    if (!courses.Contains(commands[1]))
                    {
                        courses.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    if (!courses.Contains(commands[1]))
                    {
                        courses.Insert(int.Parse(commands[2]), commands[1]);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (courses.Contains(commands[1]))
                    {
                        courses.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    if (courses.Contains(commands[1]) && courses.Contains(commands[2]))
                    {
                        string firstLesson = commands[1];
                        string secondLesson = commands[2];

                        int indexFirstLesson = courses.IndexOf(commands[1]);
                        int indexSecondLesson = courses.IndexOf(commands[2]);

                        courses.Remove(secondLesson);
                        courses.Insert(indexSecondLesson, firstLesson);
                        courses.Remove(firstLesson);
                        courses.Insert(indexFirstLesson, secondLesson);


                        if (courses.Contains(firstLesson + "-Exercise"))
                        {
                            int index = courses.IndexOf(firstLesson) + 1;
                            courses.Insert(index, firstLesson + "-Exercise");
                            courses.Remove(firstLesson + "-Exercise");
                        }
                        else if (courses.Contains(secondLesson + "-Exercise"))
                        {
                            int index = courses.IndexOf(secondLesson) + 1;
                            courses.Remove(secondLesson + "-Exercise");
                            courses.Insert(index, secondLesson + "-Exercise");
                        }
                    }
                }
                else if (commands[0] == "Exercise")
                {
                    int index = courses.IndexOf(commands[1]) + 1;
                    string lesson = commands[1];
                    string exercises = lesson + "-Exercise";

                    if (courses.Contains(commands[1]) && !courses.Contains($"{lesson}-Exercise"))
                    {
                        courses.Insert(index, exercises);
                    }
                    if (!courses.Contains(commands[1]))
                    {
                        courses.Add(lesson);
                        courses.Add(exercises);
                    }

                }

                commands = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }

        }
    }
}
