using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian() { }
        public Librarian(string firstName,string lastName,DateTime hireDare, decimal salary)
            : base(firstName,lastName)
        {
            HireDate = hireDare;
            Salary = salary;
        }
        public string ToString()
        {
            return base.Tostring() + $", Hiredate: {HireDate} , Salary: {Salary}";
        }

    }
}
