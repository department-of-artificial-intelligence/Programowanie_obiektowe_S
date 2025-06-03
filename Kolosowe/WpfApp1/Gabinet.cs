using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Gabinet : IObiekt
    {
        public string Adres { get; set; }
        public int LiczbaPracownikow { get; set; }
        public int NumerGabinetu { get; set; }
        public List<Pracownik> Pracownicy { get; set; }
        public int Id { get; set; }
    }
}
