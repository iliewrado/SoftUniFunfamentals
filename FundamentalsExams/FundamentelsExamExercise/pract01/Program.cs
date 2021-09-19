using System;
using System.Text;

namespace pract01
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            StringBuilder decripted = new StringBuilder();
            decripted.Append(encrypted);
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] command = input
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Move":
                        int count = int.Parse(command[1]);
                        for (int i = 0; i < count; i++)
                        {
                            decripted.Append(decripted[i]);
                        }
                        decripted.Remove(0, count);
                        break;
                    case "Insert":
                        int index = int.Parse(command[1]);
                        string sub = command[2];
                        decripted.Insert(index, sub);
                        break;
                    case "ChangeAll":
                        string old = command[1];
                        string newOne = command[2];
                        decripted.Replace(old, newOne);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {decripted}");
        }
    }
}
