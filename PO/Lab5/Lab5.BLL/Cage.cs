using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        public int Pojemnosc
        {
            get;
            set;
        }

        public bool CzyWymagaSprzatania
        {
            get;
            set;
        }

        public System.Collections.Generic.List<Animal> Zwierzeta
        {
            get;
            set;
        }
        public Cage() { Pojemnosc = 0; CzyWymagaSprzatania = false; Zwierzeta = new List<Animal>(); }
        public Cage(int pojemnosc, bool czyWymagaSprzatania, List<Animal> zwierzeta) { Pojemnosc = pojemnosc; CzyWymagaSprzatania = czyWymagaSprzatania; Zwierzeta = zwierzeta; }
        public override string ToString()
        {
            if (Zwierzeta.Count() == 0) return $"Pusta klatka o pojemnosci {Pojemnosc}";
            string result = $"Klatka o pojemnosci {Pojemnosc}, zwierzeta w tej klatce: \n";
            foreach (var zwierze in Zwierzeta)
            {
                result+= zwierze.ToString()+"\n";
            }
            return result;
        }
    }
    

}