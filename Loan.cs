using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    internal class Loan
    {
        private Book book;
        private Reader borrower;

        public Loan(Book book, Reader reader)
        {
            this.book = book;
            this.borrower = reader;
        }

        public Book Book { get => book; }
        public Reader Borrower { get => borrower; }
        public override string ToString()
        {
            return $"{Borrower.FirstName} {Borrower.LastName} borrowed {Book.Title}";
        }
    }
}
