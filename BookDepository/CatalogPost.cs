using System;
namespace BookDepository
{
    public class CatalogPost
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public int Year { get; set; }
        public string Adress { get; set; }
        public string Publisher { get; set; }

        public CatalogPost(string title, string author, string edition,
            string adress, string publisher, int year)
        {
            Title = title;
            Author = author;
            Edition = edition;
            Adress = adress;
            Publisher = publisher;
            Year = year;
        }

        public string GetHarvardReference()
        {
            string[] partialStep = Author.Split(' ');
            string authorReverse = $"{partialStep[1]}, {partialStep[0]}";
            string reference = $"{authorReverse} ({Year}). {Title}. {Edition}. {Adress}: {Publisher}";
            return reference;
        }
    }

    
}
