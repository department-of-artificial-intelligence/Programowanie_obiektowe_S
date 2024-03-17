using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab3
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian()
        {
            HireDate = DateTime.Now;
            Salary = 0;
        }
        public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary) : base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return "Librarian : " + base.ToString() + $" \\ {HireDate} \\ {Salary}";
        }
    }
}
