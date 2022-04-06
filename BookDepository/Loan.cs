using System;
namespace BookDepository
{
    public class Loan
    {
        public Book Book { get; set; }
        public DateTime LoanStart { get; set; }
        public DateTime ReturnDate { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public int Renewals { get; set; }

        public Loan(Book book, LibraryCard libraryCard)
        {
            Book = book;
            LibraryCard = libraryCard;
            Renewals = 0;
            LoanStart = DateTime.Now;
            ReturnDate = book.GetLoanPeriod() ==
                Book.Period.Week ?
                DateTime.Now.AddDays(7) :
                DateTime.Now.AddMonths(1);

        }
    }
}
