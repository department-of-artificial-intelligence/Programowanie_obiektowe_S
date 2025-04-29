using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumKupczyk
{
    public abstract class Jednostka
    {
        private string nazwa;
        public string Nazwa {  get => nazwa; set => Nazwa = value; }

        public Jednostka()
        {
            Nazwa = "nieznana";
        }

        public Jednostka(string Nazwa)
        {
            Nazwa = nazwa;
        }

        public float Bilans(float Bilans)
        {
            Bilans = 7;
            return Bilans;
        }
        
        public override string ToString()
        {
            return Nazwa;
        }
    }
}
