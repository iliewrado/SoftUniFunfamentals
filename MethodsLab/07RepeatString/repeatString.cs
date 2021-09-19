using System;
using System.Text;

namespace _07RepeatString
{
    class repeatString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repCount = int.Parse(Console.ReadLine());

            StringRepeter(text, repCount);

            static void StringRepeter(string text, int count)
            {
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < count; i++)
                {
                    result.Append(text);
                }
                Console.WriteLine(result);
            }
        }
    }
}
