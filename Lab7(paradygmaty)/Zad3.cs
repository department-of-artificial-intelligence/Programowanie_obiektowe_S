using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Osoba : IComparable<Osoba>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public int CompareTo(Osoba other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.Wiek.CompareTo(other.Wiek);
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, Wiek: {Wiek}";
        }
    }
}
