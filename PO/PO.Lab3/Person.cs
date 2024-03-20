using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
        FirstName = "";
        LastName = "";
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"First name: {FirstName}, last name: {LastName}";
    }

    public void Details()
    {
        Console.WriteLine(this);
    }
}
