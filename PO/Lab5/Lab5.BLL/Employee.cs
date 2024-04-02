using Lab5.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Employee: IDisplayable, IContainer
    {
        public string FirstName
        {
            get;set;
        }
        public string LastName
        {
            get; set;
        }
        public DateTime DateOfBirth
        {
            get; set;
        }

        public Employee() { }
        public Employee(string name, string sur, DateTime date)
        {
            FirstName = name;
            LastName = sur;
            DateOfBirth = date;
        }
        public override string ToString()
        {
            return $"Employee: {FirstName} | {LastName} | {DateOfBirth.ToString("yyyy.MM.dd")}";
        }

    }
}