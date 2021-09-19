using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class ProgramCourses
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
            List<string> students = new List<string>();

            while (input[0] != "end")
            {
                string course = input[0];
                string student = input[1];

                if (courseInfo.ContainsKey(course))
                {
                    students = courseInfo[course];
                    students.Add(student);
                }
                else
                {
                    students = new List<string>();
                    students.Add(student);
                    courseInfo.Add(course, students);
                }

                input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in courseInfo.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
