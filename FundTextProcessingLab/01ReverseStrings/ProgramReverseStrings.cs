using System;
using System.Linq;
using System.Text;

namespace _01ReverseStrings
{
    class ProgramReverseStrings
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                char[] reversed = text.Reverse().ToArray();
                string reverse = new string(reversed);
                Console.WriteLine($"{text} = {reverse}");
                text = Console.ReadLine();
            }
        }
    }
}
