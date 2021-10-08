using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

    }
    class ProgramStudents
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Student> students = new List<Student>();

            while (command[0] != "end")
            {
                Student student = new Student();

                student.FirstName = command[0];
                student.LastName = command[1];
                student.Age = int.Parse(command[2]);
                student.HomeTown = command[3];

                students.Add(student);

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            string cityName = Console.ReadLine();

            foreach (Student item in students
                .Where(n => n.HomeTown == cityName))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }

        }
    }
}
