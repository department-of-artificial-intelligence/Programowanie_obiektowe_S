using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol
{
    public class Pracownik 
    {
        public string Stanowisko { get; set; }
        public string Zarobki { get; set; }
        public double zdobadz()
        {
            if (Stanowisko == "dyrektor")
            {
                return 10000;
            }
            else
            {
                return 4000;
            }
        }
        public Pracownik(string stanowisko, string zarobki)
        {
            Stanowisko=stanowisko;
            Zarobki=zarobki;
        }
    }
}
