using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL {
    public class Zoo {

        public string Nazwa { get; set; }
        public IList<Employee> Pracownicy { get; set; }
        public IList<Cage> Klatki { get; set; } 
        public IList<Animal> Animal { get; set; }

        public Zoo(string nazwa, IList<Employee> pracownicy, IList<Cage> klatki, IList<Animal> animal) {
            Nazwa = nazwa;
            Pracownicy = pracownicy;
            Klatki = klatki;
            Animal = animal;
        }

        public Cage BuildCage(int v1, bool v2) {
            
        }

        public void ExpandCage(Cage cage4, int v) {
            throw new NotImplementedException();
        }
    }
}
