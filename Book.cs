namespace CSharpLibrary;

public abstract class Book
{
	public string Title { get; private set; }
	public Author Author { get; private set; }
	private string _ISBN;

	protected Book(string title, Author author, string ISBN)
	{
		Title = title;
		Author = author;
		_ISBN = ISBN;
	}

	public override string ToString()
	{
		return $"Jméno knihy: {Title}, Autor: {Author.FirstName} {Author.LastName}, ISBN: {_ISBN}";
	}
}



