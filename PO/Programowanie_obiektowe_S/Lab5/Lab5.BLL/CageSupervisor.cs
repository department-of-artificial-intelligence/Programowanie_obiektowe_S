using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public class CageSupervisor: Employee, IContainer
    {
        private DateTime _hireDate;
        private IList<Cage> _cages;

        public DateTime HireDate { get { return _hireDate; }  set { _hireDate = value; } }
        public IList<Cage> Cages { get { return _cages; } set {  _cages = value; } }
    
        public CageSupervisor(string name, string sur, DateTime DOB, DateTime hireDate, IList<Cage> cages):base(name,sur,DOB) {
            HireDate = hireDate;
            Cages = cages;
        }

        public override string ToString()
        {
            string str = $"Person:{base.ToString()},HireDate:{HireDate},Cage->";
            foreach(var cage in Cages)
            {
                str += "\n" + cage +"\n";
            }
            return str;
        }
    }
}
