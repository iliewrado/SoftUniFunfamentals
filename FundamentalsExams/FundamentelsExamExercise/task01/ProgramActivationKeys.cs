using System;

namespace task01
{
    class ProgramActivationKeys
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] command = input
                    .Split('>', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Contains":
                        string substring = command[1];
                        Console.WriteLine(rawKey
                            .Contains(substring) ? $"{rawKey} contains {substring}" : "Substring not found!");
                        break;
                    case "Flip":
                        string change = command[1];
                        int startIndex = int.Parse(command[2]);
                        int length = int.Parse(command[3]) - startIndex;
                        if (change == "Upper")
                        {
                            string oldsub = rawKey.Substring(startIndex, length);
                            substring = rawKey.Substring(startIndex, length).ToUpper();
                            rawKey = rawKey.Replace(oldsub, substring);
                            Console.WriteLine(rawKey);
                        }
                        else
                        {
                            string oldsub = rawKey.Substring(startIndex, length);
                            substring = rawKey.Substring(startIndex, length).ToLower();
                            rawKey = rawKey.Replace(oldsub, substring);
                            Console.WriteLine(rawKey);
                        }
                        break;
                    case "Slice":
                        startIndex = int.Parse(command[1]);
                        length = int.Parse(command[2]) - startIndex;
                        rawKey = rawKey.Remove(startIndex, length);
                        Console.WriteLine(rawKey);
                        break;

                }
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
