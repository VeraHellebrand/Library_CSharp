using CSharpLibrary;

namespace CSarpLibrary
{
    class Library
    {
        static void Main(string[] args)
        {
            FictionBook b1 = new FictionBook("Poslední přání", "Andrzej Sapkowski", "978 - 80 - 252 - 0493 - 6", "fantasy");
            FictionBook b2 = new FictionBook("Harry Potter and the Philosopher's Stone", "J.K. Rowling", "978-0747532743", "fantasy");
            NonFictionBook nb1 = new NonFictionBook("A Brief History of Time: From the Big Bang to Black Holes", "Stephen Hawking", "978-0-553-10953-5", 523.1);
            NonFictionBook nb2 = new NonFictionBook("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "978-0062316097", 301);
            Author a1 = new Author("Andrzej", "Sapkowski", "21.06.1948", "");
            Author a2 = new Author("J.K.", "Rowling", "31.07.1965", "");
            Author a3 = new Author("Stephen", "Hawking", "08.01.1942", "14.03.2018");
            Author a4 = new Author("Yuval Noah", "Harari", "24.02.1976", "");
            Reader r1 = new Reader("Vera", "Hellebrand");
            Reader r2 = new Reader("Samael", "Hellebrand");
            Reader r3 = new Reader("Jiri", "Hellebrand");

            LibrarySystem librarySystem = new LibrarySystem();
            librarySystem.AddBook(b1);
            librarySystem.AddBook(b2);
            librarySystem.AddBook(nb1);
            librarySystem.AddBook(nb2);
            librarySystem.AddAuthor(a1);
            librarySystem.AddAuthor(a2);
            librarySystem.AddAuthor(a3);
            librarySystem.AddAuthor(a4);
            librarySystem.AddReader(r1);
            librarySystem.AddReader(r2);
            librarySystem.AddReader(r3);

            librarySystem.LendBook(b1, r1);
            librarySystem.LendBook(b2, r1);
            librarySystem.LendBook(nb1, r2);
            librarySystem.LendBook(nb2, r3);

            //testovani
            Console.WriteLine("After lending:");
            librarySystem.DisplayLoans();
            Console.WriteLine();

            librarySystem.ReturnBook(r3.BorrowedBooks[0]);

            Console.WriteLine("After returning:");
            librarySystem.DisplayLoans();
            Console.WriteLine();

            Console.WriteLine("Readers:");
            foreach (var reader in librarySystem.Readers)
            {
                Console.WriteLine(reader.ToString());
                reader.DisplayLoans();
            }
        }
    }
}

