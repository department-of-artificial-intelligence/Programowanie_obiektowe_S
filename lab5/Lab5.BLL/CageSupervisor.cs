using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee, IContainer, IDisplayable
    {
        protected IList<Cage> _cages;
        protected DateTime _hireDate;

        public IList<Cage> Cages
        {
            get => _cages; set => _cages = value;
        }
        public DateTime HireDate
        {
            get => _hireDate; set => _hireDate = value;
        }

        public CageSupervisor(string firstName, string lastName, DateTime birthDate, DateTime hireDate, IList<Cage> cages)
            : base(firstName, lastName, birthDate)
        {
            HireDate = hireDate;
            Cages = cages ?? new List<Cage>();
        }

        public override string ToString()
        {
            string sHireDate = HireDate.ToString("dd-MM-yyyy");
            string sCages = $"Details ";
            foreach(var c in Cages)
            {
                sCages += $"\n {c.ToString()}";
            }
            return base.ToString() + $"{sHireDate}, Cages count: {Cages.Count.ToString()} {sCages}";
        }
    }
}