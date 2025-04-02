using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Librarian: Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public Librarian(string firstName = "none", string lastName = "none", DateTime hireDate = default(DateTime), decimal salary = 0)
            :base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, hire date = {HireDate}, Salary = {Salary}";
        }
    }
}
