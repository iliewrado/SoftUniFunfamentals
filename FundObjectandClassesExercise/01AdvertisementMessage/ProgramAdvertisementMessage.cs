using System;
using System.Collections.Generic;

namespace _01AdvertisementMessage
{
    class Advertisement
    {
        string[] Phrase = new string[]
            {
                 "Excellent product.",
                 "Such a great product.",
                 "I always use that product.",
                 "Best product of its category.",
                 "Exceptional product.",
                 "I can’t live without this product."
            };
        string[] Event = new string[]
        {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
        };
        string[] Author = new string[]
        {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
        };
        string[] City = new string[]
        {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
        };
        public string MessageGenerator()
        {
            Random rnd = new Random();
            string phrase = Phrase[rnd.Next(0, Phrase.Length)];
            string events = Event[rnd.Next(0, Event.Length)];
            string authors = Author[rnd.Next(0, Author.Length)];
            string cities = City[rnd.Next(0, City.Length)];
            return $"{phrase} {events} {authors} – {cities}";
        }
    }
    class ProgramAdvertisementMessage
    {
        static void Main(string[] args)
        {
            
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Advertisement advertisement = new Advertisement();

                Console.WriteLine(advertisement.MessageGenerator());
            }
        }
    }
}
