using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee, IContainer, IDisplayable
    {
        protected DateTime _hireDate;
        protected IList<Cage> _assignedCages;

        public DateTime HireDate
        {
            get => _hireDate; set => _hireDate = value;
        }

        public IList<Cage> AssignedCages
        {
            get => _assignedCages; set => _assignedCages = value;
        }

        public Cage Cage { get; set; }

        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth, DateTime hireDate, IList<Cage> assignedCages)
            : base(firstName, lastName, dateOfBirth)
        {
            HireDate = hireDate;
            AssignedCages = assignedCages ?? new List<Cage>();
        }

        public override string ToString()
        {
            var cageIds = AssignedCages.Any() ? string.Join(", ", AssignedCages.Select(c => c.Id)) : "none";
            return base.ToString() + $", Hire date: {HireDate}, Cages: {cageIds}";
        }
    }
}