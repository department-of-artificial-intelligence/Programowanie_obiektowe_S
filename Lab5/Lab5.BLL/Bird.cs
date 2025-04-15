using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL {
    public class Bird : Animal {
        public Bird(string rodzajPozywienia, int iloscNog, string pochodzenie, string gatunek, double rozpietoscSkrzydel, int wytrzymalosc)
                : base(gatunek, rodzajPozywienia, pochodzenie, iloscNog) {
            this.RozpietoscSkrzydel = rozpietoscSkrzydel;
            this.Wytrzymalosc = wytrzymalosc;
        }

        public double RozpietoscSkrzydel { get; set; }

        public int Wytrzymalosc {  get; set; }

        public double Fly() {
            return this.RozpietoscSkrzydel * this.Wytrzymalosc;
        }

    }
}
