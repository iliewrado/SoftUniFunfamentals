using System;

namespace problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string temporary = string.Empty;

                switch (command[0])
                {
                    case "TakeOdd":
                        for (int i = 1; i < password.Length; i += 2)
                        {
                            if (i % 2 != 0)
                            {
                                temporary += password[i];
                            }
                        }
                        password = temporary;
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(command[1]);
                        int length = int.Parse(command[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string sub = command[1];
                        string newSub = command[2];

                        if (password.Contains(sub))
                        {
                            while (password.Contains(sub))
                            {
                                password = password.Replace(sub, newSub);
                            }
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
