using CSharpLibrary;

class Library
{
	static void Main(string[] args)
	{
		// Vytvoření autorů.
		var author1 = new Author("Andrzej", "Sapkowski", "21.06.1948", "");
		Console.WriteLine(author1);
		var author2 = new Author("J.K.", "Rowling", "31.07.1965", "");
		var author3 = new Author("Stephen", "Hawking", "08.01.1942", "14.03.2018");
		var author4 = new Author("Yuval Noah", "Harari", "24.02.1976", "");

		// Vytvoření knih.
		var book1 = new FictionBook("Poslední přání", author1, "978-80-252-0493-6", "fantasy");
		Console.WriteLine(book1);
		var book2 = new FictionBook("Harry Potter and the Philosopher's Stone", author2, "978-0747532743", "fantasy");
		var book3 = new NonFictionBook("A Brief History of Time: From the Big Bang to Black Holes", author3, "978-0-553-10953-5", 523.1);
		Console.WriteLine(book3);
		var book4 = new NonFictionBook("Sapiens: A Brief History of Humankind", author4, "978-0062316097", 301);

		// Vytvoření čtenářů.
		var reader1 = new Reader("Veronika", "Nová");
		var reader2 = new Reader("Samuel", "Kolář");
		var reader3 = new Reader("Jan", "Straka");

        Console.WriteLine();

        // Vytvoření systému knihovny.
        var librarySystem = new LibrarySystem();

		// Přidání autorů a knih do systému knihovny.
		librarySystem.AddAuthor(author1);
		librarySystem.AddAuthor(author2);
		librarySystem.AddAuthor(author3);
		
		librarySystem.AddBook(book1);
		librarySystem.AddBook(book2);
		librarySystem.AddBook(book3);
		librarySystem.AddBook(book4);

		librarySystem.AddAuthor(author4);
		librarySystem.AddBook(book4);

		librarySystem.RemoveBook(book1);

		// Přidání čtenářů do systému knihovny.
		librarySystem.AddReader(reader1);
		librarySystem.AddReader(reader2);
		librarySystem.AddReader(reader3);

        Console.WriteLine();
        Console.WriteLine(librarySystem);
        Console.WriteLine();

        // Půjčení knih.
        librarySystem.LendBook(book1, reader1);
		librarySystem.LendBook(book2, reader1);
		librarySystem.LendBook(book3, reader2);
		librarySystem.LendBook(book4, reader3);

		// Vypsání informací o vypůjčených knihách.
		Console.WriteLine("Po vypůjčení:");
		librarySystem.DisplayLoans();
		Console.WriteLine();

		// Vrácení knihy.
		librarySystem.ReturnBook(reader3.BorrowedBooks[0]);
		librarySystem.ReturnBook(reader1.BorrowedBooks[0]);

		// Vypsání informací po vrácení knihy.
		Console.WriteLine("Po vrácení:");
		librarySystem.DisplayLoans();
		Console.WriteLine();

		// Vypsání informací o čtenářích.
		librarySystem.DisplayReadersInfo();
	}
}


