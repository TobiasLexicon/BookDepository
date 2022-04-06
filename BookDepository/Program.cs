using System;

namespace BookDepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CatalogPost testPost = new CatalogPost(
                "Generation Y: framtidens konsumenter och medarbetare gör entré!",
                "Anders Parment", "1. uppl", "Malmö", "Liber", 2008);

            testPost.Author = "Fred Eriksen";


        }
    }
}
