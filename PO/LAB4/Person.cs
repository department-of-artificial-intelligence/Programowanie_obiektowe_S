using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_LAB4
{
    public abstract class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(string FName, string LName, DateTime DOB)
        {
            FirstName=FName;
            LastName=LName;
            DateOfBirth=DOB;
        }
        public override string ToString()
        {
            return $"{FirstName} | {LastName} | {DateOfBirth}";
        }
    }
}
