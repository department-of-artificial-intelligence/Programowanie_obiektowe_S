using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumKupczyk
{
    public class Pracownik : Jednostka
    {
        private string Stanowisko;
        private float Zarobki;

        public string stanowisko { get => Stanowisko; set => Stanowisko = value; }
        public float zarobki { get => Zarobki; set => Zarobki = value; }

        public Pracownik()
        {
            Stanowisko = "nieznane";
            Zarobki = 0;
        }
        
        public Pracownik(string stanowisko, float zarobki)
        {
            Stanowisko = stanowisko;
            Zarobki = zarobki;
        }

        public override string ToString()
        {
            return base.ToString() + $"Pracownik | Stanowisko: {stanowisko}, Zarobki: {zarobki}\n";
        }

    }
}
