using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Librarian : Person
    {
        public DateTime HireDate
        {
            get;set;
        }
        public decimal Salary
        { get;set;}
        public Librarian():base() { }
        public Librarian(string firstName, string lastname, DateTime hireDate, decimal salary)
           : base(firstName, lastname)
        {
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $"HireDate{HireDate},Salary{Salary} ";
        }

    }
}
