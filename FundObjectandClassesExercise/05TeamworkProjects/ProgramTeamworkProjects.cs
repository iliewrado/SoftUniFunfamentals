using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05TeamworkProjects
{
    class ProgramTeamworkProjects
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<CreateTeam> teams = new List<CreateTeam>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] newTeam = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (teams.Any(x => x.TeamName == newTeam[1]))
                {
                    Console.WriteLine($"Team {newTeam[1]} was already created!");
                    continue;
                }
                if (teams.Any(x => x.Creator == newTeam[0]))
                { 
                    Console.WriteLine($"{newTeam[0]} cannot create another team!");
                    continue;
                }
                else
                {
                    CreateTeam team = new CreateTeam(newTeam[0], newTeam[1]);
                    teams.Add(team);
                    Console.WriteLine($"Team {newTeam[1]} has been created by {newTeam[0]}!");
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] input = command.Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!teams.Any(x => x.TeamName == input[1]))
                {
                    Console.WriteLine($"Team {input[1]} does not exist!");
                    continue;
                }
                else if (teams.Any(x => x.Members.Contains(input[0])) 
                    || teams.Any(x => x.Creator == input[0] 
                    && x.TeamName == input[1]))
                {
                    Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                    continue;
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == input[1]);
                    teams[index].Members.Add(input[0]);
                }
            }

            List<CreateTeam> disbandTeams = teams.FindAll(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            List<CreateTeam> createtTeams = teams.FindAll(x => x.Members.Count > 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, createtTeams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)));

            Console.WriteLine("Teams to disband:");
            foreach (var item in disbandTeams)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
    class CreateTeam
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        
        public List<string> Members;

        public CreateTeam(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(TeamName);
            text.AppendLine("- " + Creator);
            foreach (var item in Members)
            {
                text.AppendLine("-- " + item);
            }
            return text.ToString().TrimEnd();
        }
    }
}
