using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        //public List<Cage> Cages { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Employee(string name, string lastName, DateTime birthDate)
        {
            FirstName = name;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {BirthDate.ToString("mm/dd/yy")}";
        }
    }
}