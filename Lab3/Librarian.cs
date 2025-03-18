using System;

public class Librarian : Person {
    public decimal Salary { get; set; }

    public Librarian(string firstName, string lastName, DateTime birthDate, decimal salary)
        : base(firstName, lastName, birthDate) {
        Salary = salary;
    }

    public override string ToString() {
        return base.ToString() + $", Salary: {Salary}";
    }
}