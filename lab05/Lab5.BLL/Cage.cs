using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Cage
    {
        private int _pojemnosc {  get; set; }
        private bool _posprzatana { get; set; }
        private System.Collections.Generic.IList<Animal> _zwierzeta {  get; set; }

        public Cage(int pojemnosc, bool posprzatana, IList<Animal> zwierzeta) 
        {
            _pojemnosc = pojemnosc;
            _posprzatana = posprzatana;
            _zwierzeta = zwierzeta;
        }

        public override string ToString()
        {
            string temp ="";
            foreach(Animal animal in _zwierzeta) { temp += $"\t {animal}\n"; }
            return $"Cage | Pojemnosc: {_pojemnosc}, Posprzatana: {_posprzatana}, Zwierzeta: ";
        }
    }
}