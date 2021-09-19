using System;
using System.Collections.Generic;
using System.Linq;

namespace _08AnonymousThreat
{
    class ProgramAnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);

                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end >= elements.Count)
                    {
                        end = (elements.Count - 1);
                    }
                    for (int i = start; i < end; i++)
                    {
                        elements[start] += elements[start + 1];
                        elements.RemoveAt(start + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);
                    string partitionData = elements[index];
                    int partSize = partitionData.Length / partition;
                    int reminder = partitionData.Length % partition;
                    elements.RemoveAt(index);

                    List<string> tmpData = new List<string>();

                    for (int i = 0; i < partition; i++)
                    {
                        string tmpString = null;

                        for (int p = 0; p < partSize; p++)
                        {
                            tmpString += partitionData[(i * partSize) + p];
                        }

                        if (i == partition - 1 && reminder != 0)
                        {
                            tmpString += partitionData.Substring(partitionData.Length - reminder);
                        }

                        tmpData.Add(tmpString);
                    }
                    elements.InsertRange(index, tmpData);
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
