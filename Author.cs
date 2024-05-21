using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    internal class Author
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string dateOfDeath;
        public Author(string firstName, string lastName, string dateOfBirth, string dateOfDeath)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.dateOfDeath = dateOfDeath;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string DateOfDeath { get => dateOfDeath; set => dateOfDeath = value;}
        public override string ToString()
        {
            return $"Jméno: {firstName}, příjmení: {lastName}, datum narození: {dateOfBirth}, datum úmrtí: {dateOfDeath}";
        }
    }
}

