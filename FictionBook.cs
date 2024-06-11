namespace CSharpLibrary;

public class FictionBook : Book
{
	private string _genre;

	public FictionBook(string title, Author author, string ISBN, string genre) : base(title, author, ISBN)
	{
		_genre = genre;
	}

	public override string ToString()
	{
		return base.ToString() + $", žánr: {_genre}";
	}
}

