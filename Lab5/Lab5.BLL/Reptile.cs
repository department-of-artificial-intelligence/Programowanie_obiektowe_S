using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL {
    public class Reptile : Animal {
        public Reptile(string gatunek, int iloscNog, string pochodzenie, string rodzajPozywienia, bool czyJadowity) : base(gatunek, rodzajPozywienia, pochodzenie, iloscNog) {
            this.CzyJadowity = czyJadowity;
        }

        public bool CzyJadowity { get; set; }


    }
}
