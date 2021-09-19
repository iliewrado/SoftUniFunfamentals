using System;
using System.Linq;

namespace _11ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= initialArray.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        Exchange(initialArray, index);
                    }
                }
                else if (command[0] == "max")
                {

                    if (command[1] == "even")
                    {
                        int index = FindMaxEven(initialArray);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if (command[1] == "odd")
                    {
                        int index = FindMaxOdd(initialArray);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        int index = FindMinEven(initialArray);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if (command[1] == "odd")
                    {
                        int index = FindMinOdd(initialArray);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if (command[0] == "first")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[2] == "even")
                        {
                            int[] first = FindFirstEven(initialArray, index);
                            for (int i = 0; i < first.Length; i++)
                            {
                                if (first[i] == 0)
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", first)}]");
                                    break;
                                }
                            }

                        }
                        else if (command[2] == "odd")
                        {
                            int[] first = FindFirstOdd(initialArray, index);
                            for (int i = 0; i < first.Length; i++)
                            {
                                if (first[i] == 0)
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", first)}]");
                                    break;
                                }
                            }
                        }
                    }

                }
                else if (command[0] == "last")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[2] == "even")
                        {
                            int[] last = FindLastEven(initialArray, index);
                            for (int i = 0; i < last.Length; i++)
                            {
                                if (last[i]==0)
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", last)}]");
                                    break;
                                }
                            }
                            
                        }
                        else if (command[2] == "odd")
                        {
                            int[] last = FindLastOdd(initialArray, index);
                            for (int i = 0; i < last.Length; i++)
                            {
                                if (last[i] == 0)
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", last)}]");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", initialArray)}]");

        }

        static void Exchange(int[] currentArray, int index)
        {
            int[] firstArr = new int[currentArray.Length - index - 1];
            int[] secondArr = new int[index + 1];

            if (index < 0 || index > currentArray.Length - 1)
            {
                Console.WriteLine("Invalid index");

            }

            int arrCount = 0;
            for (int i = index + 1; i < currentArray.Length; i++)
            {
                firstArr[arrCount] = currentArray[i];
                arrCount++;
            }
            for (int i = 0; i < index + 1; i++)
            {
                secondArr[i] = currentArray[i];
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                currentArray[i] = firstArr[i];
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                currentArray[firstArr.Length + i] = secondArr[i];
            }
        }

        static int FindMaxEven(int[] array)
        {
            
            int value = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (value <= array[i])
                    {
                        value = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int FindMaxOdd(int[] array)
        {
            
            int value = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (value <= array[i])
                    {
                        value = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int FindMinEven(int[] array)
        {
            
            int value = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (value >= array[i])
                    {
                        value = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int FindMinOdd(int[] array)
        {
            
            int value = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (value >= array[i])
                    {
                        value = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int[] FindFirstOdd(int[] first, int index)
        {
            int count = 0;
            int[] odds = new int[index];


            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] % 2 != 0)
                {
                    odds[count] = first[i];
                    count++;
                    if (count == index)
                    {
                        return odds;
                    }
                }
            }
            int[] counts = new int[count];

            if (count == 0)
            {
                counts = new int[1];
                counts[0] = 0;
                return counts;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    counts[i] = odds[i];
                }

                return counts;
            }
        }

        static int[] FindFirstEven(int[] first, int index)
        {
            int count = 0;
            int[] evens = new int[index];


            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] % 2 == 0)
                {
                    evens[count] = first[i];
                    count++;
                    if (count == index)
                    {
                        return evens;
                    }
                }
            }
            int[] counts = new int[count];

            if (count == 0)
            {
                counts = new int[1];
                counts[0] = 0;
                return counts;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    counts[i] = evens[i];
                }

                return counts;
            }
        }

        static int[] FindLastEven(int[] last, int index)
        {
            int count = 0;
            int[] evens = new int[index];
            int[] first = last.Reverse().ToArray();


            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] % 2 == 0)
                {
                    evens[count] = first[i];
                    count++;
                    if (count == index)
                    {
                        return evens;
                    }
                }
            }
            int[] counts = new int[count];

            if (count == 0)
            {
                counts = new int[1];
                counts[0] = 0;
                return counts;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    counts[i] = evens[i];
                }

                return counts;
            }
            
        }

        static int[] FindLastOdd(int[] last, int index)
        {
            int count = 0;
            int[] evens = new int[index];
            int[] first = last.Reverse().ToArray();

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] % 2 != 0)
                {
                    evens[count] = first[i];
                    count++;
                    if (count == index)
                    {
                        return evens;
                    }
                }
            }
            int[] counts = new int[count];

            if (count == 0)
            {
                counts = new int[1];
                counts[0] = 0;
                return counts;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    counts[i] = evens[i];
                }

                return counts;
            }
        }
    }
}
