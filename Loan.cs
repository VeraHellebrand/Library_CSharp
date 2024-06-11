namespace CSharpLibrary;

public class Loan
{
	public Book Book { get; private set; }
	public Reader Borrower { get; private set; }
	public DateTime LoanDate { get; private set; }
	public DateTime? ReturnDate { get; private set; }

	public Loan(Book book, Reader borrower)
	{
		Book = book;
		Borrower = borrower;
		LoanDate = DateTime.Now;
	}

	public void ReturnBook()
	{
		ReturnDate = DateTime.Now;
	}

	public override string ToString()
	{
		return $"Pan/Pani {Borrower.FirstName} {Borrower.LastName} si vypůjčil(a) knihu {Book.Title} dne {LoanDate.ToShortDateString()}.";
	}
}

