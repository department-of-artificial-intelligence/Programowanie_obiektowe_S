using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumKupczyk
{
    public class FiliaBanku : SekcjaBanku
    {
        private string Adres;
        private string Kraj;

        public string adres {  get => Adres; set => Adres = value; }
        public string kraj {  get => Kraj; set => Kraj = value; }  

        public FiliaBanku()
        {
            Adres = "Nieznany";
            Kraj = "Nieznany";    
        }

        public FiliaBanku(string adres, string kraj)
        {
            Adres = adres;
            Kraj = kraj;
        }

        public override string ToString()
        {
            return base.ToString() + $"FiliaBanku | Adres: {adres}, Kraj: {kraj}\n";
        }

    }
}
