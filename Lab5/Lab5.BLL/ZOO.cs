using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        private System.Collections.Generic.List<Animals> _animals;
        private System.Collections.Generic.List<Cages> _cages;
        private System.Collections.Generic.List<Employees> _employees;
        private int _name;

        public Employees Employees
        {
            get => default;
            set
            {
            }
        }

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public Cages Cages
        {
            get => default;
            set
            {
            }
        }
    }
}