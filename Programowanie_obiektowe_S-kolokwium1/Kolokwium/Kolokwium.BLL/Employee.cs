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
        public Employee(string firstName, string lastName, DateTime dateOFBirth , DateTime shiftChangeDateTime) : base(firstName, lastName, dateOFBirth)
        {
            ShiftChangeDateTime = shiftChangeDateTime;
        }
        public override string ToString()
        {
            return base.ToString() + $"Czas zmiany warty: {ShiftChangeDateTime}";
        }


    }
}
