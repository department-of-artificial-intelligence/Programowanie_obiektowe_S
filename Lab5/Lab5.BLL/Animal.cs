using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL {
    public abstract class Animal {
        public string Gatunek { get; set; }
        public string RodzajPozywienia { get; set; }

        public string Pochodzenie { get; set; }

        public int IloscNog { get; set; }

        protected Animal(string gatunek, string rodzajPożywienia, string pochodzenie, int iloscNog) {
            this.Gatunek = gatunek;
            this.RodzajPozywienia = rodzajPożywienia;
            this.Pochodzenie = pochodzenie;
            this.IloscNog = iloscNog;
        }
    }
}
