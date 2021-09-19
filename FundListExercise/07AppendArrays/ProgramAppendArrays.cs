using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    class ProgramAppendArrays
    {
        static void Main(string[] args)
        {
            //string[] arrays = Console.ReadLine()
                //.Split("|", StringSplitOptions.RemoveEmptyEntries)
                //.Reverse()
                //.ToArray();

            //string[] result = arrays
                //.SelectMany(n => n.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                //.ToArray();

            //Console.WriteLine(string.Join(" ", result));

            Console.WriteLine(string.Join(' ', Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .SelectMany(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                .ToArray()));
        }
    }
}
