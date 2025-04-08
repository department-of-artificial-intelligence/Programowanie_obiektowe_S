using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee
    {
        private System.DateTime _dateOfHire;
        private System.Collections.Generic.List<Cage> _cages;

        public CageSupervisor(string firstName, string lastName, System.DateTime dateOfBirth, System.DateTime dateOfHire, System.Collections.Generic.List<Cage> cages) : base (firstName, lastName, dateOfBirth)
        {
            _dateOfHire = dateOfHire;
            _cages = cages;
        }

        public Cage Cage
        {
            get => default;
            set
            {
            }
        }

        public void CleanCage(Cage cage)
        {
            cage.Clean();
        }

        public void CleanAllCages()
        {
            foreach(Cage cage in _cages)
            {
                cage.Clean();
            }
        }
    }
}