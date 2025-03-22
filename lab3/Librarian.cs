using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Librarian: Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public Librarian(): base()
        {
            HireDate = DateTime.MinValue;
            Salary = 0.0m;
        }

        public Librarian(string firtsname, string lastName,DateTime hireDate, decimal salary): base(firtsname,lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $", HireDate: {HireDate}, Salary: {Salary}";
        }
    }
}
