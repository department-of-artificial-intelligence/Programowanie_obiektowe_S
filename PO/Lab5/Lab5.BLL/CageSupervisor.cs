using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lab5.BLL
{
    public class CageSupervisor : Employee, IDisplayable, IContainer
    {
        public IList<Cage> Cages { get; set; }
        public DateTime WorkStartDate { get; set; }

        public CageSupervisor(string FName, string LName, DateTime DOB, DateTime workstartdate, IList<Cage> cagess) : base(FName, LName, DOB)
        {
            WorkStartDate = workstartdate;
            Cages = cagess;
        }
        public CageSupervisor(string FName, string LName, DateTime DOB, IList<Cage> cagess) : base(FName, LName, DOB)
        {
            WorkStartDate = DateTime.MinValue;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
