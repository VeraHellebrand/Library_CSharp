namespace CSharpLibrary;

public class Reader : ILoanable
{
	private static int nextLibraryCardNumber = 1;
	private List<Loan> borrowedBooks = new List<Loan>();

	public Reader(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
		LibraryCardNumber = nextLibraryCardNumber++;
	}

	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int LibraryCardNumber { get; }
	internal IReadOnlyList<Loan> BorrowedBooks => borrowedBooks.AsReadOnly();

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
		return $"Jméno: {FirstName}, příjmení: {LastName}, číslo karty: {LibraryCardNumber}";
	}
}


