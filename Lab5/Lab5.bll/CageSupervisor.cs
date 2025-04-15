using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.bll
{

    public class CageSupervisor:Employee
    {
        IList<Cage> Cages;
        public DateTime Date;
        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth, DateTime date, IList<Cage> cages):base(firstName, lastName,dateOfBirth)
        {
            Cages = cages;
            Date=date;
        }

    }
}
