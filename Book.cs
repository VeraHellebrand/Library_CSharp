using System;

namespace CSharpLibrary
{
    public abstract class Book
    {
        private string title;
        private string author;
        private string ISBN;

        protected Book(string title, string author, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string ISBNNumber { get => ISBN; set => ISBN = value; }
    }
}


