using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Librarian : Person
    {

        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public Librarian() { 
        
            HireDate = DateTime.Now;
            Salary = 0;
        
        }

        public Librarian(string firsName, string lastName, DateTime hireDate, decimal salary) 
        : base(firsName, lastName){ 
        
            HireDate = hireDate;
            Salary = salary;

        }

        public override string ToString()
        {

            return $"Librarian | {base.ToString()}, HireDate {HireDate}, Salary {Salary}";

        }

    }
}
