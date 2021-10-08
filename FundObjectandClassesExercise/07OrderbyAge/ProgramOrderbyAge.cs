using System;
using System.Collections.Generic;
using System.Linq;

namespace _07OrderbyAge
{
    class ProgramOrderbyAge
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] information = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (information[0] != "End")
            {
                Person person = new Person
                    (information[0],
                    int.Parse(information[1]),
                    int.Parse(information[2])
                    );
                people.Add(person);

                information = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(x => x.Age)));
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public Person(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
