using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        public System.Collections.Generic.List<Animal> Zwierzeta
        {
            get;
            set;
        }

        public string Nazwa
        {
            get;
            set;
        }

        public System.Collections.Generic.List<Cage> Klatki
        {
            get;
            set;
        }

        public System.Collections.Generic.List<Employee> Pracownicy
        {
            get;
            set;
        }

        public Zoo() { Nazwa= string.Empty;Zwierzeta = new List<Animal>(); Klatki = new List<Cage>(); Pracownicy = new List<Employee>(); }
        public Zoo(string nazwa, List<Employee> pracownicy, List<Cage> klatki,List<Animal> zwierzeta) { Nazwa= nazwa; Zwierzeta = zwierzeta; Klatki= klatki; Pracownicy= pracownicy; }
        public Cage BuildCage(int pojemnosc,bool czyWymagaSprzatania) {
            Klatki.Add(new Cage(pojemnosc, czyWymagaSprzatania, new List<Animal>()));
            return Klatki[Klatki.Count() - 1];
        }
        public void ExpandCage(Cage cage, int ilosc)
        {
            cage.Pojemnosc += ilosc;
        }
    }
}