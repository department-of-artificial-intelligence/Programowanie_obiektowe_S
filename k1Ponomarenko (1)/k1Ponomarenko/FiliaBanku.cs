using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol
{
    public class FiliaBanku : SekcjaBanku
    {
        public string Adres {  get; set; }
        public string Kraj { get; set; }
        public FiliaBanku(string adres, string kraj) 
        {
            Adres = adres;
            Kraj = kraj;
        }
        public double Bilans()
        {
            return Filie.Sum(float => float.Bilans());
        }
    }
}
