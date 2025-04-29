using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumKupczyk
{
    public class SekcjaBanku : Jednostka
    {
        private float BudzetBanku;
        private List<Jednostka> Sklad;

        public float budzetBanku {  get => BudzetBanku; set => BudzetBanku = value; }
        public List<Jednostka> sklad { get => Sklad; set => Sklad = value; }

        public SekcjaBanku()
        {
            BudzetBanku = 0;
            Sklad = new List<Jednostka>();
        }

        public SekcjaBanku(float budzetBanku, List<Jednostka> sklad)
        {
            BudzetBanku = budzetBanku;
            Sklad = sklad;
        }

        public override string ToString()
        {
            return base.ToString() + $"SekcjaBanku | BudzetBanku: {budzetBanku}, Sklad {sklad}";
        }

    }
}
