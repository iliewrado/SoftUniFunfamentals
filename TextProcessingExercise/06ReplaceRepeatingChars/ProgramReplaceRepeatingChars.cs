using System;

namespace _06ReplaceRepeatingChars
{
    class ProgramReplaceRepeatingChars
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (i+1 >= text.Length)
                {
                    break;
                }
                if (text[i] == text[i + 1])
                {
                    text = text.Remove(i,1);
                    i--;
                }
            }
            
            Console.WriteLine(text);
        }
    }
}
