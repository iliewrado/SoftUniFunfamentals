using System;
using System.Collections.Generic;
using System.Linq;

namespace _07StudentAcademy
{
    class ProgramStudentAcademy
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, double> student = new Dictionary<string, double>();
            Dictionary<string, int> grades = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (student.ContainsKey(name))
                {
                    student[name] += grade;
                    grades[name]++;
                }
                else
                {
                    student.Add(name, grade);
                    grades.Add(name, 1);
                }
            }
            foreach (var item in grades)
            {
                student[item.Key] /= item.Value;
            }
            foreach (var item in student.Where(x => x.Value >= 4.5)
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
