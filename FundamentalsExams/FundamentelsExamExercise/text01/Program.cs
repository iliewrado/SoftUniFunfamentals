using System;
using System.Text;

namespace text01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder destintions = new StringBuilder(input);
            string info = string.Empty;

            while ((info = Console.ReadLine()) != "Travel")
            {
                string[] command = info
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add Stop":
                        int index = int.Parse(command[1]);
                        string stop = command[2];
                        if (index >= 0 && index < destintions.Length)
                        {
                            destintions.Insert(index, stop);
                        }
                        Console.WriteLine(destintions);
                        break;
                    case "Remove Stop":
                        index = int.Parse(command[1]);
                        int length = int.Parse(command[2]) - index + 1;
                        if (index >= 0 && index < destintions.Length
                            && length + index -1 < destintions.Length)
                        {
                            destintions.Remove(index, length);
                        }
                        Console.WriteLine(destintions);
                        break;
                    case "Switch":
                        string old = command[1];
                        string newOne = command[2];
                        input = destintions.ToString();
                        if (input.Contains(old))
                        {
                            destintions.Replace(old, newOne);
                        }
                        Console.WriteLine(destintions);
                        break;
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destintions}");
        }
    }
}
