using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        public int Name
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<Animal> Animals
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<Employee> Employees
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<Cage> Cages
        {
            get => default;
            set
            {
            }
        }

        public Cage BuildCage()
        {
            throw new System.NotImplementedException();
        }
    }
}