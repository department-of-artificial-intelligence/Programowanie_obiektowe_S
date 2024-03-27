using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        public string _naturalSrodowisko;
        public List<Employee> Employees { get; set; }
        public List<Cage> Cages { get; set; }
        public List<Animal> Animals { get; set; }


        public Zoo(string naturalSrodowisko)
        {
            _naturalSrodowisko = naturalSrodowisko;
            Employees = new List<Employee>();
            Cages = new List<Cage>();
            Animals = new List<Animal>();
        }
    }

    

}