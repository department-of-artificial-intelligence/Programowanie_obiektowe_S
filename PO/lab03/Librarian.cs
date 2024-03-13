using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public Librarian(string firstName, string lastName, 
            DateTime hireDate, int salary) 
            : base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }
    }
}
