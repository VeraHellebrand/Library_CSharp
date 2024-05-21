using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    internal class Reader : ILoanable
    {
        private string firstName;
        private string lastName;
        private static int nextLibraryCardNumber = 1;
        private int libraryCardNumber;
        private List<Loan> borrowedBooks = new List<Loan>();
        public Reader(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            libraryCardNumber = nextLibraryCardNumber++;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int LibraryCardNumber { get => libraryCardNumber; }
        internal List<Loan> BorrowedBooks { get => borrowedBooks; }
        public void AddLoan(Loan loan)
        {
            borrowedBooks.Add(loan);
        }
        public void RemoveLoan(Loan loan)
        {
            borrowedBooks.Remove(loan);
        }


        public void DisplayLoans()
        {
            foreach (var loan in BorrowedBooks)
            {
                Console.WriteLine(loan);
            }
        }

        public override string ToString()
        {
            return $"Jméno: {firstName}, příjmení: {lastName}, číslo karty: {libraryCardNumber}";
        }
    }
}

