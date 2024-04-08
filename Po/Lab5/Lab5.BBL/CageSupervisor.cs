using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BBL
{
    public class CageSupervisor : Employee, IContainer, IDisplayable
    {
        public IList<Cage>? CageS { get; set; }
        public CageSupervisor(string firstName, string lastName, DateTime dateTime,DateTime dateNow, IList<Cage>? cage) : base(firstName, lastName, dateTime,dateNow)
        {
            CageS = cage;
        }
        public CageSupervisor(string firstName, string lastName, DateTime dateTime, IList<Cage>? cage) : base(firstName, lastName, dateTime)
        {
            CageS = cage;
        }

        public override string ToString()
        {
            string cage = string.Join(", ", CageS.Select(a => a.ToString()));
            return base.ToString()+ $"Cage: {cage}";
        }
    }
}
