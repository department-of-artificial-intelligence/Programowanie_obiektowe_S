using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Client : Person 
    {
      

        public DateTime ValidityDate { get; set; }
        public TCar Car { get; set; }
        public decimal Price { get; set; }
        public Client(string firstName, string lastName, DateTime dateOFBirth, DateTime validityDate, TCar car, decimal price) : base(firstName, lastName, dateOFBirth)
        {
            ValidityDate = validityDate;
            Car = car;
            Price = price;
        }
        public override string ToString()
        {
            return base.ToString() + $"ValidityDate{ValidityDate} Cena :{Price}" + Car  ;
        }
    }
}
