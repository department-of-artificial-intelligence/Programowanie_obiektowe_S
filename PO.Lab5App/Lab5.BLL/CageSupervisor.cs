using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class CageSupervisor:Employee,IContainer
    {
        public DateTime HireDate { get; set; }
        public IList<Cage> Cages { get; set; }
        public CageSupervisor(string name,string lastName,
            DateTime birthDate,DateTime hireDate,IList<Cage> cages):base(name,lastName,birthDate)
        {
            HireDate = hireDate;
            Cages = cages;
        }
        public override string ToString()
        {
            string res=base.ToString() + $" {HireDate.ToString("mm/dd/yy")}\n";
            foreach(var cage in Cages)
            {
                res += "\t\t"+cage.ToString()+"\n";
            }
            return res ;
        }
    }
}
