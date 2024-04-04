using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee, IContainer
    {
        private DateTime _someDate;
        private IList<Cage> _cages;

        public DateTime SomeDate { get => _someDate; set => _someDate = value; }
        public IList<Cage> Cages { get => _cages; set => _cages = value; }

        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth, DateTime someDate, IList<Cage> cages)
            :base(firstName, lastName, dateOfBirth)
        {
            SomeDate = someDate;
            _cages = cages;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"some date: {SomeDate} ";
            str += string.Join<Cage>('\n', Cages);
            return str;
        }
    }
}
