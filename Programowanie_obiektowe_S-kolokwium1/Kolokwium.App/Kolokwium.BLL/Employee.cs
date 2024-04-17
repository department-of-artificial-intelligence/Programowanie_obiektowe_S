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
        public Employee(string firstName, string lastName, DateTime dateOfBirth,DateTime shiftChangeDateTime)
            :base(firstName, lastName, dateOfBirth)
        {
            ShiftChangeDateTime = shiftChangeDateTime;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"shift change date time: {ShiftChangeDateTime} ";
            return str;
        }
    }
}
