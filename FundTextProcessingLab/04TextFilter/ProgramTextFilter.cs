using System;

namespace _04TextFilter
{
    class ProgramTextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                int length = item.Length;
                string asteriks = new string('*', length);
                text = text.Replace(item, asteriks);
            }
            
            Console.WriteLine(text);
        }
    }
}
