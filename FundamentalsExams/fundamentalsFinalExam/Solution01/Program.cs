using System;
using System.Text;

namespace Solution01
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder workString = new StringBuilder();
            workString.Append(inputString);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Translate":
                        char old = char.Parse(command[1]);
                        char newOne = char.Parse(command[2]);
                        inputString = workString.ToString();
                        if (inputString.Contains(old))
                        {
                            workString.Replace(old, newOne);
                        }
                        Console.WriteLine(workString);
                        break;
                    case "Includes":
                        string check = command[1];
                        inputString = workString.ToString();
                        Console.WriteLine(inputString.Contains(check));
                        break;
                    case "Start":
                        check = command[1];
                        bool isIt = false;
                        for (int i = 0; i < check.Length; i++)
                        {
                            if (workString[i] == check[i])
                            {
                                isIt = true;
                            }
                            else
                            {
                                isIt = false;
                            }

                        }
                        Console.WriteLine(isIt);
                        break;
                    case "Lowercase":
                        inputString = workString.ToString();
                        workString.Clear();
                        workString.Append(inputString.ToLower());
                        Console.WriteLine(workString);
                        break;
                    case "FindIndex":
                        old = char.Parse(command[1]);
                        inputString = workString.ToString();
                        int index = inputString.LastIndexOf(old);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        int count = int.Parse(command[2]);
                        workString = workString.Remove(index, count);
                        Console.WriteLine(workString);
                        break;
                }
            }
        }
    }
}
