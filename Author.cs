namespace CSharpLibrary;

public class Author
{
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	public string DateOfBirth { get; private set; }
	public string DateOfDeath { get; private set; }

	public Author(string firstName, string lastName, string dateOfBirth, string dateOfDeath)
	{
		FirstName = firstName;
		LastName = lastName;
		DateOfBirth = dateOfBirth;
		DateOfDeath = dateOfDeath;
	}

	public override string ToString()
	{
		return $"Jméno: {FirstName}, příjmení: {LastName}, datum narození: {DateOfBirth}, datum úmrtí: {DateOfDeath}";
	}
}


