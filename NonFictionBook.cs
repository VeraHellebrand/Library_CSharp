using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    public class NonFictionBook : Book
    {
        private double MDT;

        public NonFictionBook(string title, string author, string ISBN, double MDT) : base(title, author, ISBN)
        {
            this.MDT = MDT;
        }
        public double MDTNumber { get => MDT; set => MDT = value; }
        public override string ToString()
        {
            return $"Jméno knihy: {Title}, Autor: {Author}, ISBN: {ISBNNumber}, MDT: {MDTNumber}";
        }
    }
}
