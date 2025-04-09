using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        private System.Collections.Generic.IList<Animal> Animals;
        private System.Collections.Generic.IList<Cage> Cages;
        private System.Collections.Generic.IList<Employee> Employees;

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public Cage Cage
        {
            get => default;
            set
            {
            }
        }
    }
}