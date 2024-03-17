namespace PO.Lab3.Classes
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian()
        {

        }

        public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary) : base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"HireDate: {HireDate}, Salary: {Salary}";
        }
    }

}

