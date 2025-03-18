using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Librarian : Person
    {
        public DateTime HireDate {  get; set; }
        public decimal Salary { get; set; }
        public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary): base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }
        public Librarian(): base()
        {
            HireDate = new DateTime(0);
            Salary = 0;
        }
        public override string ToString()
        {
            return base.ToString()+$", HireDate: {HireDate}, Salary {Salary}";
        }
    }
}
