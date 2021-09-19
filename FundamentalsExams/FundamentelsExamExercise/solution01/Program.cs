using System;
using System.Linq;
using System.Text;

namespace solution01
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder todecript = new StringBuilder();
            todecript.Append(message);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input
                    .Split(new char[] { '|', ':' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(command[1]);
                        todecript.Insert(index, " ");
                        Console.WriteLine(todecript);
                        break;
                    case "Reverse":
                        string substring = command[1];
                        message = todecript.ToString();
                        if (message.Contains(substring))
                        {
                            index = message.IndexOf(substring);
                            todecript.Replace(substring, "", index, substring.Length);
                            char[] reversed = substring.Reverse().ToArray();
                            todecript.Append(reversed);
                            Console.WriteLine(todecript);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        substring = command[1];
                        string replacement = command[2];
                        todecript.Replace(substring, replacement);
                        Console.WriteLine(todecript);
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {todecript}");
        }
    }
}
