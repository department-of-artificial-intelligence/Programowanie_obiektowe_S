using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Employee : IDisplayable
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _birthDate;

        public string FirstName
        {
            get => _firstName; set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName; set => _lastName = value;
        }
        public DateTime BirthDate
        {
            get => _birthDate; set => _birthDate = value;
        }
        public Zoo Zoo
        {
            get; set;
        }

        public Employee (string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName ?? "no defined";
            LastName = lastName ?? "no defined";
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            string sBirthDate = BirthDate.ToString("dd-MM-yyyy");
            return $"{FirstName}, {LastName}, {sBirthDate}";
        }
    }
}