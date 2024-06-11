namespace CSharpLibrary;

public class NonFictionBook : Book
{
	private double _MDT;

	public NonFictionBook(string title, Author author, string ISBN, double MDT) : base(title, author, ISBN)
	{
		_MDT = MDT;
	}

	public override string ToString()
	{
		return base.ToString() + $", MDT: {_MDT}";
	}
}

