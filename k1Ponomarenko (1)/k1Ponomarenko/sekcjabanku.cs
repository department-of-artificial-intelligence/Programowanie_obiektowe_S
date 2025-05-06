using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol
{
    public class SekcjaBanku : IInfo
    {
        public List<Pracownik>pracownicy {  get; set; } = new List<Pracownik>();
        public string Nazwa {  get; set; }
        public float BudzetBanku { get; set; } 
        public List<Jednostka> Jednostki { get; set; } =new List<Jednostka>();

        public float Bilans()
        {
            return pracownicy.Sum(p => p.zdobadz());
        }
        public SekcjaBanku(string nazwa) : base (nazwa)
        {
            Nazwa = nazwa;
        }
        
    }
}
