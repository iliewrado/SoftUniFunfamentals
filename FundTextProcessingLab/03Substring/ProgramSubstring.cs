using System;

namespace _03Substring
{
    class ProgramSubstring
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int length = wordToRemove.Length;
            int index = word.IndexOf(wordToRemove);

            while (index != -1)
            {
                word = word.Remove(index, length);
                index = word.IndexOf(wordToRemove);
            }

            Console.WriteLine(word);
        }
    }
}
