using System;
using System.Linq;

namespace _03ExtractFile
{
    class ProgramExtractFile
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            int index = text.LastIndexOf('\\')+1;
            int end = text.Length - index;

            string[] file = text.Substring(index, end).Split(".");
                        
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
