using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL {
    public class Mammal : Animal {
        public string SrodowiskoNaturalne { get; set; }
        public Mammal(string rodzajPozywienia, int iloscNog,
                        string pochodzenie, string gatunek, string srodowiskoNaturalne) : base(gatunek, rodzajPozywienia, pochodzenie, iloscNog) {
            this.SrodowiskoNaturalne = srodowiskoNaturalne;
        }

        
    }
}
