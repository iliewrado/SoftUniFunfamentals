using System;
using System.Collections.Generic;
using System.Linq;

namespace _08CompanyUsers
{
    class ProgramCompanyUsers
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            List<string> employees = new List<string>();

            while (command[0] != "End")
            {
                string company = command[0];
                string employee = command[1];

                if (companies.ContainsKey(company))
                {
                    employees = companies[company];
                    if (!employees.Contains(employee))
                    {
                        employees.Add(employee);
                    }
                }
                else
                {
                    employees = new List<string>();
                    employees.Add(employee);
                    companies.Add(company, employees);
                }
                command = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var emp in item.Value)
                {
                    Console.WriteLine($"-- {emp}");
                }
            }


        }
    }
}
