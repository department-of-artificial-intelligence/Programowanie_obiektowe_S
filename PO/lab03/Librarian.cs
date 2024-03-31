using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab03
{
    public class Librarian : Person 
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian() : base()
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
            string a = base.ToString();
            a += $" | Hire date: {HireDate} | Salary: {Salary}";
            return a;
        }
    }
}
