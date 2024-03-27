using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel;
using System.Xml.Linq;

public abstract class Person
{
	public string FirstName{
		get;
		set;
	}
	public string LastName { get; set; }
	public DateTime DateOfBirth { get; set; }

	public Person(string firstName, string lastName, DateTime dateOfBirth )
    {
        FirstName=firstName;
        LastName=lastName;
        DateOfBirth=dateOfBirth;
    }
    public override string ToString()
    {
        return $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}. ";
    }
}
