using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Articles20
{
    class ProgramArticles20
    {
        static void Main(string[] args)
        {
            int nuberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            Article article = new Article();


            for (int i = 0; i < nuberOfArticles; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                article = new Article()
                {
                    Title = input[0],
                    Content = input[1],
                    Author = input[2]
                };
                articles.Add(article);
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (orderCriteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            else
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));


        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
