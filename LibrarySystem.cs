using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    internal class LibrarySystem : ILoanable
    {
        private List<Book> books = new List<Book>();
        private List<Author> authors = new List<Author>();
        private List<Reader> readers = new List<Reader>();
        private List<Loan> currentLoans = new List<Loan>();

        public LibrarySystem()
        {
        }

        public List<Book> Books { get => books; }
        public List<Author> Authors { get => authors; }
        public List<Reader> Readers { get => readers; }
        internal List<Loan> CurrentLoans { get => currentLoans; }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void AddAuthor(Author author)
        {
            authors.Add(author);
        }
        public void AddReader(Reader reader)
        {
            readers.Add(reader);
        }
        public void LendBook(Book book, Reader reader)
        {
            if (IsBookAvailable(book))
            {
                Loan newLoan = new Loan(book, reader);
                CurrentLoans.Add(newLoan);
                reader.AddLoan(newLoan);
            }
            else
            {
                Console.WriteLine("Book is already borrowed.");
            }
        }
        public void LendBook(Loan loan)
        {

            CurrentLoans.Add(loan);
            loan.Borrower.AddLoan(loan);

        }


        public void ReturnBook(Loan loan)
        {
            CurrentLoans.Remove(loan);
            loan.Borrower.RemoveLoan(loan);
        }


        private bool IsBookAvailable(Book book)
        {
            foreach (var loan in CurrentLoans)
            {
                if (loan.Book == book)
                {
                    return false;
                }
            }
            return true;
        }
        public void DisplayLoans()
        {
            foreach (var loan in CurrentLoans)
            {
                Console.WriteLine(loan);
            }
        }
    }
}
