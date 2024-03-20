using System;

public class Librarian : Person
{
	public DateTime HireDate { get; set; }
	public decimal Salary { get; set; }

	public Librarian()
	:base()
	{
		HireDate = DateTime.Now;
		Salary = 0.0m;
	}

	public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary)
	:base(firstName, lastName)
	{
		HireDate = hireDate;
		Salary = salary;
	}

    public override string ToString()
    {
        var str = base.ToString();
		str += $"hire date: {HireDate}, salary: {Salary}";
		return str;
    }
}
