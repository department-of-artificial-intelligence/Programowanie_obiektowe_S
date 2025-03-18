using System;

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public Person(string firstName, string lastName, DateTime birthDate) {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }

    public override string ToString() {
        return $"{FirstName} {LastName}, Born: {BirthDate.ToShortDateString()}";
    }
}