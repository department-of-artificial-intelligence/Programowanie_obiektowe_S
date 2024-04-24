using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.BLL
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary {  get; set; }
        public Librarian() :base()
        {
            HireDate = DateTime.MinValue;
            Salary = 0;
        }
        public Librarian(string firstname, string lastname, DateTime hireDate, decimal salary) : base(firstname,lastname)
        {
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $"Data zatrudnienia: {HireDate} Pesja: {Salary}";
        }
    }
}
