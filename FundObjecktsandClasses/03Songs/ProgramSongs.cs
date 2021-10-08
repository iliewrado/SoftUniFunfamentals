using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Songs
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    class ProgramSongs
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] colection = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = colection[0];
                string title = colection[1];
                string time = colection[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = title;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }  
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}

