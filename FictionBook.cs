using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    public class FictionBook : Book
    {
        private string genre;

        public FictionBook(string title, string author, string ISBN, string genre) : base(title, author, ISBN)
        {
            this.genre = genre;
        }
        public string Genre { get => genre; set => genre = value; }
        public override string ToString()
        {
            return $"Jméno knihy: {Title}, Autor: {Author}, ISBN: {ISBNNumber}, žánr: {Genre}";
        }
    }
}
