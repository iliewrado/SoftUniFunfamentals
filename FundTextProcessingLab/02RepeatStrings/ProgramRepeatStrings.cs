using System;
using System.Text;

namespace _01ReverseStrings
{
    class ProgramReverseStrings
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new StringBuilder();

            foreach (var item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    builder.Append(item);
                }
            }

            Console.WriteLine(builder);
        }
    }
}
