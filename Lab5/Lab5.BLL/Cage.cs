using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL {
    public class Cage {
        public Cage(int numer, bool czyPosprzatac, List<Animal> Zwierzeta) {
            this.Numer = numer;
            this.czyPosprzatac = czyPosprzatac;
            this.Zwierzeta = Zwierzeta;
        }

        public int Numer { get; set; }

        public bool czyPosprzatac { get; set; } 

        public IList<Animal> Zwierzeta { get; set; }

    }
}
