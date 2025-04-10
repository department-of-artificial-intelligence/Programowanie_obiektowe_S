using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee
    {
        private DateTime _dateOfHire;
        private IList<Cage> _cage;

        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth, DateTime dateOfHire, IList<Cage> cage) : base(firstName, lastName, dateOfBirth)
        {
            _dateOfHire = dateOfHire;
            _cage = cage;
        }

        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
        {
            _dateOfHire = DateTime.Now;
            _cage = new List<Cage>();
        }

        public CageSupervisor(Employee employee)
            :base(employee)
        {
            _dateOfHire = DateTime.Now;
            _cage = new List<Cage>();
        }
    }
}