using System.Text;

namespace CSharpLibrary;

public class LibrarySystem : ILoanable
{
	private List<Book> books = new List<Book>();
	private List<Author> authors = new List<Author>();
	private List<Reader> readers = new List<Reader>();
	private List<Loan> currentLoans = new List<Loan>();

	public LibrarySystem() { }

	public IReadOnlyList<Book> Books => books.AsReadOnly();
	public IReadOnlyList<Author> Authors => authors.AsReadOnly();
	public IReadOnlyList<Reader> Readers => readers.AsReadOnly();
	internal IReadOnlyList<Loan> CurrentLoans => currentLoans.AsReadOnly();


	// Kniha není přidána, pokud autor knihy neexistuje v systému knihovny.
	public void AddBook(Book book)
	{
		// Kontrola existence autora knihy v systému knihovny před přidáním knihy.
		if (authors.Contains(book.Author))
		{
			books.Add(book);
			Console.WriteLine($"Kniha '{book.Title}' byla přidána do systému knihovny.");
		}
		else
		{
			Console.WriteLine($"Autor {book.Author.FirstName} {book.Author.LastName} neexistuje v systému knihovny. Nejprve přidejte autora.");
		}
	}
	// Odebrání knihy ze systému knihovny.
	public void RemoveBook(Book book)
	{
		if (books.Contains(book))
		{
			books.Remove(book);
			Console.WriteLine($"Kniha '{book.Title}' byla odebrána ze systému knihovny.");
		}
		else
		{
			Console.WriteLine($"Kniha '{book.Title}' není v systému knihovny.");
		}
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
		if (IsBookAvailable(book) && books.Contains(book))
		{
			Loan newLoan = new Loan(book, reader);
			currentLoans.Add(newLoan);
			reader.AddLoan(newLoan);
		}
		else if (!books.Contains(book))
		{
			Console.WriteLine($"Kniha '{book.Title}' neexistuje v systému knihovny.");
		}
		else
		{
			Console.WriteLine("Kniha je již vypůjčená.");
		}
	}

	public void LendBook(Loan loan)
	{
		currentLoans.Add(loan);
		loan.Borrower.AddLoan(loan);
	}

	public void ReturnBook(Loan loan)
	{
		currentLoans.Remove(loan);
		loan.Borrower.RemoveLoan(loan);
	}

	private bool IsBookAvailable(Book book)
	{
		return !currentLoans.Any(loan => loan.Book == book);
	}

	public void DisplayLoans()
	{
		foreach (var loan in currentLoans)
		{
			Console.WriteLine(loan);
		}
	}

	public void DisplayReadersInfo()
	{
		Console.WriteLine("Informace o čtenářích:");
		foreach (var reader in readers)
		{
			Console.WriteLine(reader.ToString());
			reader.DisplayLoans();
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Knihy v knihovním systému:");
		foreach (var book in books)
		{
			string availability = currentLoans.Any(loan => loan.Book == book) ? "Nedostupná" : "Dostupná";
			stringBuilder.AppendLine($"- {book.Title} ({book.Author.FirstName} {book.Author.LastName}): {availability}");
		}
		return stringBuilder.ToString();
	}
}

