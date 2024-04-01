using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee, IDisplayable, IContainer
    {
        public IList<Cage> Cages { get; set; }
        public DateTime WorkStartDate { get; set; }

        public CageSupervisor(string FirstName, string LastName, DateTime dateOfBirth, DateTime workstartdate, IList<Cage> cages) : base(FirstName, LastName, dateOfBirth)
        {
            WorkStartDate = workstartdate;
            Cages = cages;
        }
    }
}
