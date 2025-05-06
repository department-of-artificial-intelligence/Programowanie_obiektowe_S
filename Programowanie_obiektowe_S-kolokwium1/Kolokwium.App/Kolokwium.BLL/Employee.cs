using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Employee : Person
    {
        public DateTime ShiftChangeDateTime { get; set; }
        public Employee(string firstName, string lastName, DateTime dateOfBirth, DateTime shiftChangeDate) : base (firstName, lastName, dateOfBirth) 
        { 
            ShiftChangeDateTime = shiftChangeDate;
        }
        public override string ToString()
        {
            string napis = "";

            napis += $"ShiftChangeDateTime: {ShiftChangeDateTime}";
            return base.ToString() + napis;

        }
    }
}
