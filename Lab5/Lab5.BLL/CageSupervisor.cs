using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee
    {
        protected DateTime _hireDate;
        protected IList<Cage> _cages;

        public DateTime HireDate
        {
            get => _hireDate; set => _hireDate = value;
        }

        public IList<Cage> Cages
        {
            get => _cages; set => _cages = value;
        }

        public Cage Cage { get; set; }

        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth, DateTime hireDate, IList<Cage> cages)
            : base(firstName, lastName, dateOfBirth)
        {
            HireDate = hireDate;
            Cages = cages ?? new List<Cage>();
        }

        public override string ToString()
        {
            var cageIds = Cages.Any() ? string.Join(", ", Cages.Select(c => c.Id)) : "none";
            return base.ToString() + $", Hire date: {HireDate}, Cages: {cageIds}";
        }
    }
}