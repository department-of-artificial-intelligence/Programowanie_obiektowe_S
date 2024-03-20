using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.Data;

public class Author
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Nationality { get; set; }

	public Author()
	{ 
		FirstName = string.Empty;
		LastName = string.Empty;
		Nationality = string.Empty;
	}
	public Author(string firstName, string lastName, string nationality)
    {
        FirstName=firstName;
        LastName=lastName;
        Nationality=nationality;
    }
    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name {LastName}, Nationality: {Nationality}";
    }
}
