using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.WpfApp
{
    public class Student
    {
        private string Imie;
        private string Nazwisko;
        private string Wydzial;
        private int NrIndeksu;

        public string imie { get => Imie; set => Imie = value; }
        public string nazwisko { get => Nazwisko; set => Nazwisko = value; }
        public string wydzial { get => Wydzial; set => Wydzial = value; }
        public int nrIndeksu { get => NrIndeksu; set => NrIndeksu = value; }
    }
}
