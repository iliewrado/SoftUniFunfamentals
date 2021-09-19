using System;
using System.Collections.Generic;

namespace _03WordSynonyms
{
    class ProgramWordSynonyms
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<string>> wordSynonym = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordSynonym.ContainsKey(word))
                {
                    wordSynonym[word].Add(synonym);
                }
                else
                {
                    wordSynonym.Add(word, new List<string>() { synonym });
                }
                
            }
            foreach (var item in wordSynonym)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
